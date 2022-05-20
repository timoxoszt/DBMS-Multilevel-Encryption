<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Dyrynda\Database\Support\GeneratesUuid;

class Order extends Model
{
    use HasFactory, GeneratesUuid;

    protected $fillable = [
        'uuid',
        'user_id',
        'ma_sp',
        'so_luong',
        'ngay_dat',
        'user_uuid',
    ];
}
