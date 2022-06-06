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
            'password' => bcrypt('zF4gLrez6Gt72CzHT'),
            'user_role' => Crypt::encryptString('ChuShopHang'),
            'user_type' => Crypt::encryptString('Owner'),
            'section' => Crypt::encryptString('[Order,Product,User]'),
            'time' => Crypt::encryptString('day'),
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
            'user_role' => Crypt::encryptString('KeToan'),
            'user_type' => Crypt::encryptString('Manage'),
            'section' => Crypt::encryptString('[Order,Product,User]'),
            'time' => Crypt::encryptString('7h-17h'),
        ]);

        $hiep = User::create([
            'ho_ten' => Crypt::encryptString('Trương Văn Hiệp'),
            'sdt' => Crypt::encryptString('08127336123'),
            'stk' => Crypt::encryptString('712371284721'),
            'cmnd' => Crypt::encryptString('12637127378'),
            'dia_chi' => Crypt::encryptString('Quảng Trị'),
            'ngay_sinh' => Crypt::encryptString('2002/02/02'),
            'email' => 'hieptv@gmail.com',
            'password' => bcrypt('HAgTgjgFB53F5YFns'),
            'user_role' => Crypt::encryptString('ThuKho'),
            'user_type' => Crypt::encryptString('Manage'),
            'section' => Crypt::encryptString('Product'),
            'time' => Crypt::encryptString('7h-17h'),
        ]);

        $giaohang = User::create([
            'ho_ten' => Crypt::encryptString('Người giao hàng'),
            'sdt' => Crypt::encryptString('08127336456'),
            'stk' => Crypt::encryptString('712371284126'),
            'cmnd' => Crypt::encryptString('12631723712'),
            'dia_chi' => Crypt::encryptString('Quận 1, TP HCM'),
            'ngay_sinh' => Crypt::encryptString('1999/02/02'),
            'email' => 'shipper@gmail.com',
            'password' => bcrypt('9a9hC]RA)LsvnU~w<'),
            'user_role' => Crypt::encryptString('NguoiGiaoHang'),
            'user_type' => Crypt::encryptString('Employee'),
            'section' => Crypt::encryptString('Order'),
            'time' => Crypt::encryptString('8h-16h'),
        ]);

        $khachhang = User::create([
            'ho_ten' => Crypt::encryptString('Khách mua hàng'),
            'sdt' => Crypt::encryptString('08127123123'),
            'stk' => Crypt::encryptString('712234512312'),
            'cmnd' => Crypt::encryptString('126312312256'),
            'dia_chi' => Crypt::encryptString('Khu phố 6, Linh Trung, Thủ Đức'),
            'ngay_sinh' => Crypt::encryptString('1990/03/03'),
            'email' => 'customer@gmail.com',
            'password' => bcrypt('@v5]LJ.9)Wa,,2=Nk'),
            'user_role' => Crypt::encryptString('NguoiMuaHang'),
            'user_type' => Crypt::encryptString('Customer'),
            'section' => Crypt::encryptString('Product'),
            'time' => Crypt::encryptString('day'),
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
