<?php

namespace Database\Seeders;

use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\Crypt;
use App\Models\User;
use App\Models\Product;
use App\Models\Order;

class DatabaseSeeder extends Seeder
{
    /**
     * Seed the application's database.
     *
     * @return void
     */
    public function run()
    {
        // \App\Models\User::factory(10)->create();
        $tien = User::create([
            'ho_ten' => Crypt::encryptString('Vi Minh Tiến'),
            'sdt' => Crypt::encryptString('0987253671'),
            'stk' => Crypt::encryptString('918293474892'),
            'cmnd' => Crypt::encryptString('1912783712'),
            'dia_chi' => Crypt::encryptString('Bù Đăng, Bình Phước'),
            'ngay_sinh' => Crypt::encryptString('2002/01/02'),
            'email' => 'tienvm@gmail.com',
            'password' => bcrypt('Gy?&dP%W38hpk38SUhw'),
        ]);

        $long = User::create([
            'ho_ten' => Crypt::encryptString('Đỗ Xuân Long'),
            'sdt' => Crypt::encryptString('0987217634'),
            'stk' => Crypt::encryptString('918291283123'),
            'cmnd' => Crypt::encryptString('12348712365'),
            'dia_chi' => Crypt::encryptString('Bến Cát, Bình Dương'),
            'ngay_sinh' => Crypt::encryptString('2002/01/01'),
            'email' => 'longdx@gmail.com',
            'password' => bcrypt('9=HE=MQz9VvWLvcw*sX'),
        ]);

        $hiep = User::create([
            'ho_ten' => Crypt::encryptString('Trương Văn Hiệp'),
            'sdt' => Crypt::encryptString('08127336123'),
            'stk' => Crypt::encryptString('712371284721'),
            'cmnd' => Crypt::encryptString('12637127378'),
            'dia_chi' => Crypt::encryptString('Quảng Trị'),
            'ngay_sinh' => Crypt::encryptString('2002/02/02'),
            'email' => 'hieptv@gmail.com',
            'password' => bcrypt('r6u29XBX4?-!%@kRS&^'),
        ]);

        $dep = Product::create([
            'ma_sp' => 'GD001',
            'ten_sp' => 'Dép tổ ong',
            'dvt' => 'Đôi',
            'gia' => 15000,
        ]);

        $giay = Product::create([
            'ma_sp' => 'GD002',
            'ten_sp' => 'Giày thượng đình',
            'dvt' => 'Đôi',
            'gia' => 50000,
        ]);

        $tong = Product::create([
            'ma_sp' => 'GD003',
            'ten_sp' => 'Tông lào cao cấp',
            'dvt' => 'Đôi',
            'gia' => 25000,
        ]);

        $but = Product::create([
            'ma_sp' => 'VPP001',
            'ten_sp' => 'Bút bi',
            'dvt' => 'Cây',
            'gia' => 5000,
        ]);

        $tay = Product::create([
            'ma_sp' => 'VPP002',
            'ten_sp' => 'Tẩy',
            'dvt' => 'Cái',
            'gia' => 2000,
        ]);

        $don1 = Order::create([
            'user_id' => 1,
            'ma_sp' => 'VPP001',
            'so_luong' => 5,
        ]);

        $don2 = Order::create([
            'user_id' => 2,
            'ma_sp' => 'VPP002',
            'so_luong' => 5,
        ]);
    }
}
