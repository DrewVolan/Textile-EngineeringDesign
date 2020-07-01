<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <link href="css/style.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Open+Sans&display=swap" rel="stylesheet">
    <title>Синхронизированный сайт</title>
</head>
<body>
    <div class="container background-container">
    <header class="header  container-sm">
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <div class="collapse navbar-collapse" id="navbarTogglerDemo01">
                <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                    <li class="nav-item active">
                        <a class="nav-link" href="./pcinfo.php">Информация о Характеристиках ПК</a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="./workshops.php">Информация о Цехах</a>
                    </li>
                </ul>
            </div>
            </nav>
        <article>
            <h1>Информация о компании</h1>
            <p>Не следует, однако забывать, что реализация намеченных плановых заданий требуют
                определения и уточнения форм развития. Идейные соображения высшего порядка,
                а также сложившаяся структура организации позволяет оценить значение соответствующий
                условий активизации. <br> Таким образом дальнейшее развитие различных форм деятельности
                требуют определения и уточнения новых предложений.</p>
        </article>
    </header>
    <main class="container-sm">
        <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
            <div class="carousel-inner">
                <!-- <?php
                    $link = mysqli_connect('std-mysql', 'std_1313', 'drewIvlev', 'std_1313');

                    mysqli_set_charset($link, "utf8");

                    if(mysqli_connect_errno())
                    {
                    echo 'Ошибка в подключении к базе данных ('.mysqli_connect_errno().'):'. mysqli_connect_error();
                    exit();
                    }

                    $result = mysqli_query($link, "SELECT * FROM `Feedbacks`");

                    $first_active = false;
                ?> -->

                <?php while ($feedback = mysqli_fetch_assoc($result)): ?>
                    <?php if ($first_active == TRUE): ?>
                        <div class="carousel-item">
                    <?php else: ?>
                        <div class="carousel-item active">
                    <?php endif ?>
                    <?php $first_active = TRUE ?>
                        <div class="feedback">
                            <span class="feedback__username"><?php echo $feedback["Name"]; ?></span>
                            <p class="feedback__text"><?php echo $feedback["Text"]; ?></p>
                            <div class="stars">
                                <div class="stars__block">
                                    <span class="stars__description">Качество</span>
                                    <div class="rating_block--disbled rating_block--quality">
                                        <?php for ($i = 0; $i < 10; $i++): ?>
                                            <?php if ($i == 10 - $feedback["Quality"]): ?>
                                                <input type="radio" checked disabled />
                                                <label class="label_rating"></label>
                                            <?php else: ?>
                                            <input type="radio" disabled />
                                            <label class="label_rating"></label>
                                            <?php endif ?>
                                        <?php endfor; ?>
                                    </div>
                                </div>
                                <div class="stars__block">
                                    <span class="stars__description">Скорость</span>
                                    <div class="rating_block--disbled rating_block--speed">
                                        <?php for ($j = 0; $j < 10; $j++): ?>
                                            <?php if ($j == 10 - $feedback["Speed"]): ?>
                                                <input type="radio" checked disabled/>
                                                <label class="label_rating"></label>
                                                <?php else: ?>
                                                <input type="radio" disabled/>
                                                <label class="label_rating"></label>
                                                <?php endif ?>
                                        <?php endfor; ?>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                <?php endwhile; ?>
                </div>
            <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
              <span class="carousel-control-prev-icon" aria-hidden="true"></span>
              <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
              <span class="carousel-control-next-icon" aria-hidden="true"></span>
              <span class="sr-only">Next</span>
            </a>
          </div>
        <div class="feedback__add">
            <h2>Добавите свой отзыв!</h2>
            <form class="feedback__form"
                method="post"
                action="./sendFeedback.php"
                enctype="multipart/form-data"
                autocomplete="off">
                <div class="feedback__fill">
                    <label for="feedback__name">Имя пользователя</label>
                    <input name="feedback__name" id="feedback__name" type="text" required>
                    <label for="feedback__text">Текст отзыва</label>
                    <textarea name="feedback__text" id="feedback__text" cols="30" rows="10" required></textarea>
                </div>
                <div class="stars">
                    <div class="stars__block">
                        <span class="stars__description">Качество</span>
                        <div class="rating_block rating_block--quality">
                            <input name="rating--quality" value="10" id="rating_10--quality" type="radio" />
                            <label for="rating_10--quality" class="label_rating"></label>
                            <input name="rating--quality" value="9" id="rating_9--quality" type="radio" />
                            <label for="rating_9--quality" class="label_rating"></label>
                            <input name="rating--quality" value="8" id="rating_8--quality" type="radio" />
                            <label for="rating_8--quality" class="label_rating"></label>
                            <input name="rating--quality" value="7" id="rating_7--quality" type="radio" />
                            <label for="rating_7--quality" class="label_rating"></label>
                            <input name="rating--quality" value="6" id="rating_6--quality" type="radio" />
                            <label for="rating_6--quality" class="label_rating"></label>
                            <input name="rating--quality" value="5" id="rating_5--quality" type="radio" />
                            <label for="rating_5--quality" class="label_rating"></label>
                            <input name="rating--quality" value="4" id="rating_4--quality" type="radio" />
                            <label for="rating_4--quality" class="label_rating"></label>
                            <input name="rating--quality" value="3" id="rating_3--quality" type="radio" />
                            <label for="rating_3--quality" class="label_rating"></label>
                            <input name="rating--quality" value="2" id="rating_2--quality" type="radio" />
                            <label for="rating_2--quality" class="label_rating"></label>
                            <input name="rating--quality" value="1" id="rating_1--quality" type="radio" />
                            <label for="rating_1--quality" class="label_rating"></label>
                        </div>
                    </div>
                    <div class="stars__block">
                        <span class="stars__description">Скорость</span>
                        <div class="rating_block rating_block--speed">
                            <input name="rating--speed" value="10" id="rating_10--speed" type="radio" />
                            <label for="rating_10--speed" class="label_rating"></label>
                            <input name="rating--speed" value="9" id="rating_9--speed" type="radio" />
                            <label for="rating_9--speed" class="label_rating"></label>
                            <input name="rating--speed" value="8" id="rating_8--speed" type="radio" />
                            <label for="rating_8--speed" class="label_rating"></label>
                            <input name="rating--speed" value="7" id="rating_7--speed" type="radio" />
                            <label for="rating_7--speed" class="label_rating"></label>
                            <input name="rating--speed" value="6" id="rating_6--speed" type="radio" />
                            <label for="rating_6--speed" class="label_rating"></label>
                            <input name="rating--speed" value="5" id="rating_5--speed" type="radio" />
                            <label for="rating_5--speed" class="label_rating"></label>
                            <input name="rating--speed" value="4" id="rating_4--speed" type="radio" />
                            <label for="rating_4--speed" class="label_rating"></label>
                            <input name="rating--speed" value="3" id="rating_3--speed" type="radio" />
                            <label for="rating_3--speed" class="label_rating"></label>
                            <input name="rating--speed" value="2" id="rating_2--speed" type="radio" />
                            <label for="rating_2--speed" class="label_rating"></label>
                            <input name="rating--speed" value="1" id="rating_1--speed" type="radio" />
                            <label for="rating_1--speed" class="label_rating"></label>
                        </div>
                    </div>
                </div>
                <button class="feedback__send" type="submit">Отправить отзыв</button>
            </form>
        </div>
    </main>
    <footer class="footer container-sm">
        <a class="copyright" href="#">Курсовой проект <br> Волейко А.В. <br> Ивлев Д.С. <br> 2020</a>
    </footer>
    </div>

    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>

    <script src="js/index.js"></script>

</body>
</html>