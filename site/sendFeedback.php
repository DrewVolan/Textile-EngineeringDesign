<?php
    $name = $_POST['feedback__name'];
    $text = $_POST['feedback__text'];
    $speed = $_POST['rating--speed'];
    $quality =$_POST['rating--quality'];

    $link = mysqli_connect('std-mysql', 'std_1313', 'drewIvlev', 'std_1313');

    mysqli_set_charset($link, "utf8");

    if(mysqli_connect_errno())
    {
    echo 'Ошибка в подключении к базе данных ('.mysqli_connect_errno().'):'. mysqli_connect_error();
    exit();
    }

    $result = mysqli_query($link, "INSERT INTO `Feedbacks` (Name, Text, Quality, Speed) VALUES ('$name','$text', '$quality', '$speed')");

    header ('Location: /');  // перенаправление на нужную страницу
    exit();
?>