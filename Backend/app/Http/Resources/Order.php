<?php

namespace App\Http\Resources;

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
        // return parent::toArray($request);
        return [
            'uuid' => $this->uuid,
            'user_id' => $this->user_id,
            'ma_sp' => $this->ma_sp,
            'so_luong' => $this->so_luong,
            'ngay_dat' => $this->created_at,
        ];
    }
}
