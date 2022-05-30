<?php

namespace App\Http\Resources;
use DB;
use Illuminate\Contracts\Encryption\DecryptException;
use Illuminate\Support\Facades\Crypt;

use Illuminate\Http\Resources\Json\JsonResource;

class Order extends JsonResource
{
    /**
     * Transform the resource into an array.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return array|\Illuminate\Contracts\Support\Arrayable|\JsonSerializable
     */
    public function toArray($request)
    {
        $product = DB::table('products')->where('ma_sp', $this->ma_sp)->first();
        if(is_null($product)){
            $ten_sp = "Product is not exist.";
        }else{
            $ten_sp = $product->ten_sp;
        }
        $user = DB::table('users')->where('id', $this->user_id)->first();
        return [
            'uuid' => $this->uuid,
            'user_uuid' => $user->uuid,
            'user_name' => Crypt::decryptString($user->ho_ten),
            'ma_sp' => $this->ma_sp,
            'ten_sp' => $ten_sp,
            'so_luong' => $this->so_luong,
            'ngay_dat' => $this->created_at->format('d/m/Y'),
        ];
    }
}
