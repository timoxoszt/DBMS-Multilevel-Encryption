<?php

namespace App\Http\Resources;

use Illuminate\Http\Resources\Json\JsonResource;

class Product extends JsonResource
{
    /**
     * Transform the resource into an array.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return array|\Illuminate\Contracts\Support\Arrayable|\JsonSerializable
     */
    public function toArray($request)
    {
        return [
            'ma_sp' => $this->ma_sp,
            'ten_sp' => $this->ten_sp,
            'dvt' => $this->dvt,
            'gia' => $this->gia,
            'image' => $this->image,
        ];
    }
}
