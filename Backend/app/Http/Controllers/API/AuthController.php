<?php
   
namespace App\Http\Controllers\API;
   
use Illuminate\Http\Request;
use App\Http\Controllers\API\BaseController as BaseController;
use Illuminate\Contracts\Encryption\DecryptException;
use Illuminate\Support\Facades\Auth;
use Validator;
use App\Models\User;
use App\Http\Resources\User as UserResource;
use Illuminate\Support\Facades\Crypt;
   
class AuthController extends BaseController
{
    public function signin(Request $request)
    {
        if(Auth::attempt([
            'email' => $request->email, 
            'password' => $request->password,
            ])){ 
                $authUser = Auth::user(); 
                $success['token'] =  $authUser->createToken('TRtescsx34WM2s6xn7fXGEaE73nbxkmAXWpZ9EQ55MfnbxyVsmUBnbkvAZg5zBEcdWh4WDk96Apg9whftY4g4UgSxNQqYUKaHjG664sgtKhuZVV3zNRqbh2fbJYf')->plainTextToken; 
                $success['user_type'] = Crypt::decryptString($authUser->user_type);
                $success['user_role'] = Crypt::decryptString($authUser->user_role);
                $success['section'] = Crypt::decryptString($authUser->section);
                $success['time'] = Crypt::decryptString($authUser->time);
                $success['ho_ten'] = Crypt::decryptString($authUser->ho_ten);
                $success['email'] = $authUser->email;
    
                return $this->sendResponse($success, 'User signed in');
            } 
            else{ 
                return $this->sendError('Unauthorised.', ['error'=>'Unauthorised']);
            } 
    }

    public function signup(Request $request)
    {
        try{
            $validator = Validator::make($request->all(), [
                'ho_ten' => 'required',
                'stk' => 'required|string|max:20',
                'sdt' => 'required|string|max:15',
                'cmnd' => 'required|string|max:30',
                'dia_chi' => 'required|string|max:100',
                'ngay_sinh' => 'required|date', // YYYY-MM-DD
                'email' => 'required|email',
                'password' => 'required',
                'confirm_password' => 'required|same:password',
            ]);
    
            if($validator->fails()){
                return $this->sendError('Error validation', $validator->errors());       
            }
    
            $authUser = User::create([
                'ho_ten' => Crypt::encryptString($request->ho_ten),
                'stk' => Crypt::encryptString($request->stk),
                'sdt' => Crypt::encryptString($request->sdt),
                'cmnd' => Crypt::encryptString($request->cmnd),
                'dia_chi' => Crypt::encryptString($request->dia_chi),
                'ngay_sinh' => Crypt::encryptString($request->ngay_sinh),
                'user_role' => Crypt::encryptString('NguoiMuaHang'),
                'user_type' => Crypt::encryptString('Customer'),
                'section' => Crypt::encryptString('Product'),
                'time' => Crypt::encryptString('date'),
                'email' => $request->email,
                'password' => bcrypt($request->password),
            ]);
            $success['token'] =  $authUser->createToken('TRtescsx34WM2s6xn7fXGEaE73nbxkmAXWpZ9EQ55MfnbxyVsmUBnbkvAZg5zBEcdWh4WDk96Apg9whftY4g4UgSxNQqYUKaHjG664sgtKhuZVV3zNRqbh2fbJYf')->plainTextToken;
            $success['ho_ten'] =  Crypt::decryptString($authUser->ho_ten);
            $success['user_type'] = Crypt::decryptString($authUser->user_type);
            $success['user_role'] = Crypt::decryptString($authUser->user_role);
            $success['section'] = Crypt::decryptString($authUser->section);
            $success['time'] = Crypt::decryptString($authUser->time);
            $success['email'] =  $authUser->email;
    
            return $this->sendResponse($success, 'User created successfully.');
        }catch(\Exception $e){
            return $this->sendError('Email existed.');       
        }
    }

    public function signout(Request $request)
    {
        try{
            // Revoke all tokens...
            $authUser = Auth::user(); 
            $success['uuid'] = $authUser->uuid;
            $success['ho_ten'] =  Crypt::decryptString($authUser->ho_ten);
            $authUser->tokens()->delete();
            return $this->sendResponse($success, 'User signed out.');
        }catch(\Exception $e){
            return $this->sendError('Signout error');
        }
    }      
   
}