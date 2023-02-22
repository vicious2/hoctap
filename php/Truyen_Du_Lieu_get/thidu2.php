<?php
    $ten = isset($_GET["txtten"]) ? $_GET["txtten"] : "";
    $tuoi = isset($_GET["txttuoi"]) ? $_GET["txttuoi"] : "";
    $thongtin = ($ten == "" || $tuoi == "") ? "" : "Họ tên: $ten. Tuổi tôi là: $tuoi."; 
?>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Trang truyền dữ liệu GET</title>
</head>
<body>
    <form action="" method="GET">
            Họ tên: 
</body>

</html>