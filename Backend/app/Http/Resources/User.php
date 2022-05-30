<?php

namespace App\Http\Resources;

use Illuminate\Http\Resources\Json\JsonResource;
use Illuminate\Contracts\Encryption\DecryptException;
use Illuminate\Support\Facades\Crypt;

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
        return [
            'uuid' => $this->uuid,
            'ho_ten' => Crypt::decryptString($this->ho_ten),
            'sdt' => Crypt::decryptString($this->sdt),
            'dia_chi' => Crypt::decryptString($this->dia_chi),
            'stk' => Crypt::decryptString($this->stk),
            'cmnd' => Crypt::decryptString($this->cmnd),
            'ngay_sinh' => Crypt::decryptString($this->ngay_sinh),
            'email' => $this->email,
            'ngay_dk' => $this->created_at->format('d/m/Y'),
        ];
    }
}
