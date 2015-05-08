<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
    <title>Book Store</title>
</head>
<body>
    <form action="book-store.php" method="GET">
        <div>
            <label for="text">
                Input
                <br/>
                <textarea name="text" id="text" rows="18" cols="100">Gambardella, Matthew/XML Developer's Guide/Computer/44.95/2000-10-01/An in-depth look at creating applications with XML.
Ralls, Kim/Midnight Rain/Fantasy/19.15/2000-12-16/A former architect battles corporate zombies, an evil sorceress, and her own childhood to become queen of the world.
Corets, Eva/Maeve Ascendant/Fantasy/6.95/2000-11-17/After the collapse of a nanotechnology society in England, the young survivors lay the foundation for a new society.
Corets, Eva/Oberon's Legacy/Fantasy/5.00/2001-03-10/In post-apocalypse England, the mysterious agent known only as Oberon helps to create a new life for the inhabitants of London. Sequel to Maeve Ascendant.
Randall, Cynthia/Lover Birds/Romance/5.95/2000-09-02/When Carla meets Paul at an ornithology conference, tempers fly as feathers get ruffled.
Thurman, Paula/Splish Splash/Romance/4.95/2000-11-02/A deep sea diver finds true love twenty thousand leagues beneath the sea.</textarea>
            </label>
        </div>
        <div>
            <label for="min-price">
                Min Price:
                <br/>
                <input type="text" name="min-price" id="min-price" value="5.00"/>
            </label>
        </div>
        <div>
            <label for="max-price">
                Max Price:
                <br/>
                <input type="text" name="max-price" id="max-price" value="10.45"/>
            </label>
        </div>
        <div>
            <label for="sort">
                Sort by:
                <br/>
                <select name="sort" id="sort">
                    <option value="genre">genre</option>
                    <option value="author">author</option>
                    <option value="publish-date">publish date</option>
                </select>
            </label>
        </div>
        <div>
            <label for="order">
                Order:
                <br/>
                <select name="order" id="order">
                    <option value="ascending">ascending</option>
                    <option value="descending">descending</option>
                </select>
            </label>
        </div>
        <input type="submit"/>
    </form>

    <?php
        date_default_timezone_set ('Europe/Sofia');
    $minPrice = floatval($_GET['min-price']);
    $maxPrice = floatval($_GET['max-price']);
    $sort = $_GET['sort'];
    $order = $_GET['order'];
    $text = $_GET['text'];

    $books = preg_split("/\r?\n/", $text, -1, PREG_SPLIT_NO_EMPTY);
    $result = [];
    foreach ($books as $book) {
        $bookInfo = preg_split("/\s*\/\s*/", $book, -1, PREG_SPLIT_NO_EMPTY);
        $result[] = ['author' => $bookInfo[0], 'name' => $bookInfo[1], 
        'genre' => $bookInfo[2], 'price' => floatval($bookInfo[3]), 
        'date' => strtotime($bookInfo[4]), 'info' => $bookInfo[5]];
    }

    usort($result, function($a, $b) use($sort, $order)
    {
        if ($sort == 'genre') {
            if (strcmp($a['genre'], $b['genre']) == 0) {
                 return $a['date'] > $b['date'] ? 1 : -1;
            } else if ($order == 'ascending') {  
                return strcmp($a['genre'], $b['genre']);  
            } else {
                return strcmp($b['genre'], $a['genre']);
            }
        }
        if ($sort == 'author') {
            if (strcmp($a['author'], $b['author']) == 0) {
                 return $a['date'] > $b['date'] ? 1 : -1;
            } else if ($order == 'ascending') {  
                return strcmp($a['author'], $b['author']);  
            } else {
                return strcmp($b['author'], $a['author']);
            }
        }

        if ($sort == 'publish-date') {
            if ($order == 'ascending') {  
                return $a['date'] > $b['date'] ? 1 : -1;
            } else {
                return $a['date'] < $b['date'] ? 1 : -1;
            }
        }
    });

    foreach ($result as $book) {
        if ($book['price'] >= $minPrice && $book['price'] <= $maxPrice) {
            echo "<div><p>" . htmlspecialchars($book['name']) . "</p><ul><li>" . htmlspecialchars($book['author']) . 
            "</li><li>" . htmlspecialchars($book['genre']) . 
            "</li><li>" . htmlspecialchars(number_format($book['price'], 2, '.', '')) . 
            "</li><li>" . date("Y-m-d", $book['date']) . 
            "</li><li>" . htmlspecialchars($book['info']) . "</li></ul></div>";
        }
        // echo $book['price'] . '-' , $minPrice . '-' . $maxPrice;
        // echo '<br>';
    }






    ?>
</body>
</html>