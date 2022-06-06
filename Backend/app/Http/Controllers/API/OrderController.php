<?php

namespace App\Http\Controllers\API;

use App\Http\Controllers\API\BaseController as BaseController;
use App\Http\Resources\Order as OrderResource;
use Illuminate\Contracts\Encryption\DecryptException;
use Illuminate\Support\Facades\Crypt;

use App\Models\Order;
use Validator;
use Auth;
use DB;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;

class OrderController extends BaseController
{
        /*
        ========= POLICY =========
        -- Thêm-Sửa-Xóa Orders|Users|Products -- 
        UserRole: {ChuShopHang}
        UserType: {Owner}
        Section: {Order Product User}

        -- Thêm-Sửa-Xóa Orders && Xem Users --
        UserRole: {KeToan} 
        UserType: {Manager}
        Section: {Order Product User}

        -- Thêm-Sửa-Xóa Products --
        UserRole: {ThuKho} 
        UserType: {Manager}
        Section: {Product}

        -- Xem Orders --
        UserRole: {NguoiGiaoHang} 
        UserType: {Employee}
        Section: {Order}

        -- Xem-Sửa-Xóa {Order || Thông tin cá nhân} của chính mình && Xem Products --
        UserRole: {NguoiMuaHang}
        UserType: {Customer}
        Section: {Product}
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */

     //  ONLY ChuShopHang && NguoiGiaoHang && KeToan INDEX AND SHOW  //
    public function index()
    {
        $authUser = Auth::user();
        if((Crypt::decryptString($authUser->user_type) == "Owner" && Crypt::decryptString($authUser->user_role) == "ChuShopHang") || (Crypt::decryptString($authUser->user_type) == "Employee" && Crypt::decryptString($authUser->user_role) == "NguoiGiaoHang") || (Crypt::decryptString($authUser->user_type) == "Manager" && Crypt::decryptString($authUser->user_role) == "KeToan")){
            $orders = Order::all();
            return $this->sendResponse(OrderResource::collection($orders), 'Orders fetched.');
        }else{
            return $this->sendError('Permission denied.');
        }
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
        $authUser = Auth::user();
        if((Crypt::decryptString($authUser->user_type) == "Owner" && Crypt::decryptString($authUser->user_role) == "ChuShopHang") || (Crypt::decryptString($authUser->user_type) == "Employee" && Crypt::decryptString($authUser->user_role) == "NguoiGiaoHang") || (Crypt::decryptString($authUser->user_type) == "Manager" && Crypt::decryptString($authUser->user_role) == "KeToan")){
            $order = Order::where('uuid', $uuid)->first();
            if (is_null($order)) {
                return $this->sendError('Order does not exist.');
            }
            return $this->sendResponse(new OrderResource($order), 'Order fetched.');
        }else{
            return $this->sendError('Permission denied.');
        }
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
    public function update(Request $request, $uuid)
    {
        $authUser = Auth::user();
        $order = Order::where('uuid', $uuid)->first();

        if(($order->user_id == $authUser->id) || (Crypt::decryptString($authUser->user_type) == "Owner" && Crypt::decryptString($authUser->user_role) == "ChuShopHang") || (Crypt::decryptString($authUser->user_type) == "Manager" && Crypt::decryptString($authUser->user_role) == "KeToan")){
            $order = Order::where('uuid', $uuid)->first();
            if (is_null($order)) {
                return $this->sendError('Order does not exist.');
            }
            $input = $request->all();
            $validator = Validator::make($input, [
                'ma_sp' => 'required|string',
                'so_luong' => 'required|integer',
            ]);
            if($validator->fails()){
                return $this->sendError($validator->errors());       
            }
            try{                      
                $order->ma_sp = $input['ma_sp'];
                $order->so_luong = $input['so_luong'];
                $order->save();

                return $this->sendResponse(new OrderResource($order), 'Order updated.');
            }catch(\Exception $e){
                return $this->sendError('Permission denied.');
            }
        }else{
            return $this->sendError('Permission denied.');
        }
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
        if(($order->user_id == $user->id) || (Crypt::decryptString($authUser->user_type) == "Owner" && Crypt::decryptString($authUser->user_role) == "ChuShopHang") || (Crypt::decryptString($authUser->user_type) == "Employee" && Crypt::decryptString($authUser->user_role) == "NguoiGiaoHang") || (Crypt::decryptString($authUser->user_type) == "Manager" && Crypt::decryptString($authUser->user_role) == "KeToan")){           
            $order->delete();
            return $this->sendResponse([], 'Order deleted.');              
        }else{
            return $this->sendError('Permission denied.');
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
