<?php

namespace App\Http\Resources;

use Illuminate\Http\Resources\Json\JsonResource;

class User extends JsonResource
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
            'ho_ten' => $this->ho_ten,
            'sdt' => $this->sdt,
            'dia_chi' => $this->dia_chi,
            'stk' => $this->stk,
            'cmnd' => $this->cmnd,
            'ngay_sinh' => $this->ngay_sinh,
            'email' => $this->email,
            'ngay_dk' => $this->created_at->format('d/m/Y'),
        ];
    }
}
