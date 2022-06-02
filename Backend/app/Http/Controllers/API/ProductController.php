<?php

namespace App\Http\Controllers\API;

use App\Http\Controllers\API\BaseController as BaseController;
use App\Http\Resources\Product as ProductResource;

use App\Models\Product;
use Validator;
use Auth;
use DB;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;

class ProductController extends BaseController
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $products = Product::all();
        return $this->sendResponse(ProductResource::collection($products), 'Products fetched.');
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
            'ten_sp' => 'required|string',
            'ma_sp' => 'required|string|max:10',            
            'dvt' => 'required|string|max:20',            
            'gia' => 'required|integer',                      
        ]);

        if($validator->fails()){
            return $this->sendError('Create product failed.', ['error'=>'Check your input.']);   
        } 

        $product = Product::create([
            'ten_sp' => $request->ten_sp,             
            'dvt' => $request->dvt,
            'ma_sp' => $request->ma_sp,   
            'gia' => $request->gia,
        ]);           
        
        return $this->sendResponse(new ProductResource($product), 'Created product.');
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($ma_sp)
    {
        $product = Product::where('ma_sp', $ma_sp)->first();
        if (is_null($product)) {
            return $this->sendError('Product does not exist.');
        }
        return $this->sendResponse(new ProductResource($product), 'Product fetched.');
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
    public function update(Request $request, $ma_sp)
    {
        $product = Product::where('ma_sp', $ma_sp)->first();
        if (is_null($product)) {
            return $this->sendError('Product does not exist.');
        }
        $input = $request->all();        
            
        $validator = Validator::make($input, [
            'ten_sp' => 'required|string',
            'ma_sp' => 'required|string|max:10',            
            'dvt' => 'required|string|max:20',            
            'gia' => 'required|integer',  
        ]);

        if($validator->fails()){
            return $this->sendError($validator->errors());       
        }        
       
        try{                      
            $product->ten_sp = $input['ten_sp'];
            $product->dvt = $input['dvt'];
            $product->ma_sp = $input['ma_sp'];
            $product->gia = $input['gia'];
            $product->save();

            return $this->sendResponse(new ProductResource($product), 'Product updated.');
        }catch(\Exception $e){
            return $this->sendError('Permission denied.');
        }
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($ma_sp)
    {
        $product = Product::where('ma_sp', $ma_sp)->first();

        if (is_null($product)) {
            return $this->sendError('Product does not exist.');
        }
        try{
            $product->delete();
            return $this->sendResponse([], 'Product deleted.');
        }          
        catch(\Exception $e){
            return $this->sendError('Unauthorised.');
        }      
    }
}
