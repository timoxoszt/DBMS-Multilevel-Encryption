<?php

namespace App\Http\Resources;
use DB;

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
        $user = DB::table('users')->where('id', $this->user_id)->first();
        // return parent::toArray($request);
        return [
            'uuid' => $this->uuid,
            'user_uuid' => $user->uuid,
            'user_name' => $user->ho_ten,
            'ma_sp' => $this->ma_sp,
            'so_luong' => $this->so_luong,
            'ngay_dat' => $this->created_at->format('d/m/Y'),
        ];
    }
}
