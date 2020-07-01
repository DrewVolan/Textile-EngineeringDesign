<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Синхронизированный сайт</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <div class="collapse navbar-collapse" id="navbarTogglerDemo01">
                <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                    <li class="nav-item active">
                        <a class="nav-link" href="./index.php">Отзывы</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="./workshops.php">Информация о Цехах</a>
                    </li>
                </ul>
            </div>
            </nav>
<div class="container">
<?php
        $link = mysqli_connect('std-mysql', 'std_1313', 'drewIvlev', 'std_1313');

        mysqli_set_charset($link, "utf8");

        if(mysqli_connect_errno())
        {
        echo 'Ошибка в подключении к базе данных ('.mysqli_connect_errno().'):'. mysqli_connect_error();
        exit();
        }

        $result = mysqli_query($link, "SELECT * FROM `Users`");
    ?>

<table class="table">
        <thead>
            <tr>
                <th scope="col">Идентификатор</th>
                <th scope="col">Логин</th>
                <th scope="col">Роль</th>
                <th scope="col">Название ПК</th>
                <th scope="col">Название пользователя ПК</th>
                <th scope="col">Операционная система</th>
                <th scope="col">Разрадность процессора</th>
                <th scope="col">Модель процессора</th>
                <th scope="col">Количество ядер процессора</th>
                <th scope="col">Дата обновления данных</th>
            </tr>
        </thead>
        <tbody>

    <?php while ($info = mysqli_fetch_assoc($result)): ?>
            <tr>
            <th scope="row"><?php echo $info['Id'] ?></th>
            <td><?php echo $info['Login'] ?></td>
            <td><?php echo $info['Role'] ?></td>
            <td><?php echo $info['PcName'] ?></td>
            <td><?php echo $info['PcUserName'] ?></td>
            <td><?php echo $info['Os'] ?></td>
            <td><?php echo $info['CpuBitRate'] ?></td>
            <td><?php echo $info['CpuModel'] ?></td>
            <td><?php echo $info['CpuCoreCount'] ?></td>
            <td><?php echo $info['DateRecordHardwareInfo'] ?></td>
            </tr>
    <?php endwhile; ?>
        </tbody>
        </table>
</div>

    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>

</body>
</html>