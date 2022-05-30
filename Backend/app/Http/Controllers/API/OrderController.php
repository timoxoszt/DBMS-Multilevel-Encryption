<?php

namespace App\Http\Controllers\API;

use App\Http\Controllers\API\BaseController as BaseController;
use App\Http\Resources\Order as OrderResource;

use App\Models\Order;
use Validator;
use Auth;
use DB;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;

class OrderController extends BaseController
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */

     //  ONLY ADMIN INDEX AND SHOW  //
    public function index()
    {
        $orders = Order::all();
        return $this->sendResponse(OrderResource::collection($orders), 'Orders fetched.');
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $validator = Validator::make($request->all(),[
            'so_luong' => 'required|integer',
            'ma_sp' => 'required|string|max:10',            
        ]);

        if($validator->fails()){
            return $this->sendError('Create order failed.', ['error'=>'Check your input.']);   
        }
        $user = Auth::user(); 
        $order = Order::create([
            'user_id' => $user->id,             
            'so_luong' => $request->so_luong,
            'ma_sp' => $request->ma_sp,   
        ]);           
        
        return $this->sendResponse(new OrderResource($order), 'Created order.');
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($uuid)
    {
        $order = Order::where('uuid', $uuid)->first();
        if (is_null($order)) {
            return $this->sendError('Order does not exist.');
        }
        return $this->sendResponse(new OrderResource($order), 'Order fetched.');
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($uuid)
    {
        $user = Auth::user();
        $order = Order::where('uuid', $uuid)->first();

        if (is_null($order)) {
            return $this->sendError('Order does not exist.');
        }
        // Check Authorise Order Delete
        if($order->user_id == $user->id){           
            $order->delete();
            return $this->sendResponse([], 'Order deleted.');              
        }else{
            return $this->sendError('Unauthorised.');
        } 
    }

    public function mybills()
    {
        $user = Auth::user();
        $orders = Order::where('user_id', $user->id)->get();  
        try{
            return $this->sendResponse(OrderResource::collection($orders), 'Orders fetched.');
        }catch(\Exception $e){
            return $this->sendResponse([],'Orders fetched.');
        }
    }
}
