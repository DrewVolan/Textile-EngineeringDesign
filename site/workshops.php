<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Синхронизированный сайт</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    <style>
    .mb-20 {
        display:block;
        margin-bottom: 20px;
    }
    </style>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
            <div class="collapse navbar-collapse" id="navbarTogglerDemo01">
                <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                    <li class="nav-item active">
                        <a class="nav-link" href="./index.php">Отзывы</a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="./pcinfo.php">Информация о Характеристиках ПК</a>
                    </li>
                </ul>
            </div>
            </nav>


        <div class="container">

        <h1 class="mb-20">Планы эвакуаций цехов</h1>

            <?php
                $link = mysqli_connect('std-mysql', 'std_1313', 'drewIvlev', 'std_1313');

                mysqli_set_charset($link, "utf8");

                if(mysqli_connect_errno())
                {
                echo 'Ошибка в подключении к базе данных ('.mysqli_connect_errno().'):'. mysqli_connect_error();
                exit();
                }

                $result = mysqli_query($link, "SELECT * FROM `Workshops`");

                while ($test = mysqli_fetch_assoc($result))
                {
                    echo '<div class="mb-20">';
                    echo $test['Id'] . ' ';
                    echo $test['Name'] . ' ';
                    echo '<img src="data:image/jpeg;base64,'.base64_encode($test['Plan']).'" />';
                    echo '<br>';
                    echo "</div>";
                }
            ?>

    </div>

    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>

</body>
</html>