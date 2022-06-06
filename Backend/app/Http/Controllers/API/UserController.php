<?php

namespace App\Http\Controllers\API;

use App\Http\Controllers\API\BaseController as BaseController;
use Illuminate\Contracts\Encryption\DecryptException;
use Illuminate\Support\Facades\Crypt;
use App\Http\Resources\User as UserResource;
use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use App\Models\User;
use Validator;
use Auth;
use DB;

class UserController extends BaseController
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
        UserType: {Managerr}
        Section: {Product}

        -- Xem Orders --
        UserRole: {NguoiGiaoHang} 
        UserType: {Employee}
        Section: {Order}

        -- Xem-Sửa-Xóa {Order || Thông tin cá nhân} của chính mình && Xem Products --
        UserRole: {NguoiMuaHang}
        UserType: {Customer}
        Section: {Product}
    /*
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $authUser = Auth::user();
        if((Crypt::decryptString($authUser->user_type) == "Owner" && Crypt::decryptString($authUser->user_role) == "ChuShopHang") || (Crypt::decryptString($authUser->user_type) == "Manager" && Crypt::decryptString($authUser->user_role) == "KeToan")){
            $users = User::all();
            return $this->sendResponse(UserResource::collection($users), 'Users fetched.');
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
        //
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
        if((Crypt::decryptString($authUser->user_type) == "Owner" && Crypt::decryptString($authUser->user_role) == "ChuShopHang") || (Crypt::decryptString($authUser->user_type) == "Manager" && Crypt::decryptString($authUser->user_role) == "KeToan")){
            $user = User::where('uuid', $uuid)->first();
            if (is_null($user)) {
                return $this->sendError('User does not exist.');
            }
            return $this->sendResponse(new UserResource($user), 'User fetched.');
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
        if((Crypt::decryptString($authUser->user_type) == "Owner" && Crypt::decryptString($authUser->user_role) == "ChuShopHang")){
            $user = User::where('uuid', $uuid)->first();
            if (is_null($user)) {
                return $this->sendError('User does not exist.');
            }
            $input = $request->all();
            $validator = Validator::make($input, [
                'email' => 'required|string',
                'ho_ten' => 'required|string',
                'sdt' => 'required',
                'dia_chi' => 'required',
                'stk' => 'required',
                'cmnd' => 'required',
                'ngay_sinh' => 'required',
            ]);
            if($validator->fails()){
                return $this->sendError($validator->errors());       
            }
            try{           
                $user->ho_ten = Crypt::encryptString($input['ho_ten']);
                $user->email = $input['email'];
                $user->sdt = Crypt::encryptString($input['sdt']);
                $user->dia_chi = Crypt::encryptString($input['dia_chi']);
                $user->stk = Crypt::encryptString($input['stk']);
                $user->cmnd = Crypt::encryptString($input['cmnd']);
                $user->ngay_sinh = Crypt::encryptString($input['ngay_sinh']);
                $user->save();
    
                return $this->sendResponse(new UserResource($user), 'User updated.');
            }catch(\Exception $e){
                return $this->sendError('Permission denied.');
            };
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
        $authUser = Auth::user();
        if((Crypt::decryptString($authUser->user_type) == "Owner" && Crypt::decryptString($authUser->user_role) == "ChuShopHang") || (Crypt::decryptString($authUser->user_type) == "Manager" && Crypt::decryptString($authUser->user_role) == "KeToan")){
            $user = User::where('uuid', $uuid)->first();

            if (is_null($user)) {
            return $this->sendError('User does not exist.');
            }
            try{
                $user->delete();
                return $this->sendResponse([], 'User deleted.');
            }          
            catch(\Exception $e){
                return $this->sendError('Permission denied.');
            }   
        }else{
            return $this->sendError('Permission denied.');
        }           
    }

    public function profile(Request $request)
    {
        $user = Auth::user();
        return $this->sendResponse(new UserResource($user), 'User signed in.');
    }

    public function updatemyprofile(Request $request)
    {
        $user = Auth::user();
        if (is_null($user)) {
            return $this->sendError('User does not exist.');
        }
        $input = $request->all();
        $validator = Validator::make($input, [
            'email' => 'required|string',
            'ho_ten' => 'required|string',
            'sdt' => 'required',
            'dia_chi' => 'required',
            'stk' => 'required',
            'cmnd' => 'required',
            'ngay_sinh' => 'required',
        ]);
        if($validator->fails()){
            return $this->sendError($validator->errors());       
        }
        try{
            $user->ho_ten = Crypt::encryptString($input['ho_ten']);
            $user->stk = Crypt::encryptString($input['stk']);
            $user->sdt = Crypt::encryptString($input['sdt']);
            $user->cmnd = Crypt::encryptString($input['cmnd']);
            $user->dia_chi = Crypt::encryptString($input['dia_chi']);
            $user->ngay_sinh = Crypt::encryptString($input['ngay_sinh']);
            $user->email = $input['email'];
            $user->save();

            return $this->sendResponse(new UserResource($user), 'Your profile updated.');
        }catch(\Exception $e){
            return $this->sendError('Your email maybe used or update error.');
        }
    }
}
