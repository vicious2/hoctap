<?php
    //1. sử dụng hàm md5 để mã hóa chuỗi => sử dụng khi lưu mật khẩu vào CSDL
    $s1 = "hello";
    $s2 = md5($s1);
    echo $s2;
    $kq1 = md5("hello1") == $s2 ? "Mật khẩu đúng" : "Mật khẩu sai";
    echo $kq1;
    echo "<br/> ---------------------- <br/>";
    //2. Hàm chuyển đổi một chuỗi sang chữ in đầu tiên
    $s3 = "cuoc doi that ngan ngui";
    echo ucwords($s3);
    echo "<br/> ---------------------- <br/>";
    echo strtoupper($s3);
    echo "<br/> ---------------------- <br/>";
    //3. Hàm xóa kí tự 
    $s4 = "@@@@@@@@@@@ TT @@@@@@@@@@@";
    echo ltrim($s4,'@');
    echo "<br/> ---------------------- <br/>";
    echo rtrim($s4,'@');
    echo "<br/> ---------------------- <br/>";
    echo trim($s4,'@');
?>