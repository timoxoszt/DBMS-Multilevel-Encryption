<?php

namespace App\Http\Controllers\API;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use App\Rules\MatchOldPassword;
use Illuminate\Support\Facades\Hash;
use App\Models\User;
use App\Http\Controllers\API\BaseController as BaseController;
use Illuminate\Support\Facades\Auth;

class ChangePasswordController extends BaseController
{
    public function store(Request $request)
    {
        $request->validate([
            'current_password' => ['required', new MatchOldPassword],
            'new_password' => ['required'],
            'new_confirm_password' => ['same:new_password'],
        ]);

        try{
            User::find(auth()->user()->id)->update(['password'=> Hash::make($request->new_password)]);
            return $this->sendResponse([], 'Change password successfully.');
        }catch(\Exception $e){
            return $this->sendError('Change password error');
        }
    }
}