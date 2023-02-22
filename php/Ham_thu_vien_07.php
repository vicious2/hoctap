<?php
//Các hàm thư viện về mảng trong PHP
$arr = ["HTML","CSS","JS","PHP","ASP","JAVA"];
//1. Hàm đếm số phần tử của mảng
echo count($arr);
echo "<br/> ---------------------- <br/>"; 
//2. Thêm phần tử đầu tiên vào mảng
array_unshift($arr,"PYTHON");
var_dump($arr);
echo "<br/> ---------------------- <br/>";
//3. Thêm phần tử cuối vào mảng
array_push($arr,"Bat luc");
var_dump($arr);
echo "<br/> ---------------------- <br/>";
//4. Xóa phần tử đầu trong mảng
array_shift($arr);
var_dump($arr);
echo "<br/> ---------------------- <br/>";
//5. Xóa phần tử cuối trong mảng
array_pop($arr);
var_dump($arr);
echo "<br/> ---------------------- <br/>";
//6. Hàm trích mảng con trong mảng gốc
$subarr = array_slice($arr,1,2);
var_dump($subarr);
?>