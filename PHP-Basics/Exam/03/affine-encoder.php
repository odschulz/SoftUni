<!DOCTYPE html>
<html>

    <head>
        <title>Affine Encoder</title>
        <meta charset="utf-8" />
    </head>

    <body>
        <form method="get" action="affine-encoder.php">
            <label for="jsonTable">
                Text to encrypt:
                <br/>
                <textarea name="jsonTable" id="jsonTable" rows="10" cols="40">[["god","save","the","queen"],[7,2]]</textarea>
            </label>
            <br/>
            <input type="submit"/>
        </form>
        <?php
        $jsonTable = json_decode($_GET['jsonTable']);
        $m = 26;
        $k = intval($jsonTable[1][0]);
        $s = intval($jsonTable[1][1]);
        $words = $jsonTable[0];
        $empty = false;
        foreach ($words as $word) {
            if (!$word == '') {
                $empty = true;
            }
        }
        if (!$empty) {
            echo "<table border='1' cellpadding='5'><tr><td></td></tr></table>";
            die;
        }
        
        // $x = ord(strtoupper('g')) - ord('A');
        $longest = getLongest($words);
        // var_dump($x);
        // E(x) = (k*x + s) % m

        // echo chr((($k*$x + $s) % $m) + ord('A'));
        
        // var_dump($longest);
        // echo encryptChar($k, $s, $m, 'g');

        echo "<table border='1' cellpadding='5'>";

        foreach ($words as $word) {
            echo '<tr>';

            for ($i = 0; $i < $longest; $i++) { 
                if ($i > strlen($word) - 1) {
                    echo '<td></td>';
                } else if (preg_match('/[A-Za-z]/', $word[$i])){
                    echo "<td style='background:#CCC'>" . encryptChar($k, $s, $m, $word[$i]) . "</td>";
                } 
                else {
                     echo "<td style='background:#CCC'>" . htmlspecialchars($word[$i]) . "</td>";
                }
            }
            echo '</tr>';
        }
        echo '</table>';






        function encryptChar($k, $s, $m, $char)
        {
            $x = ord(strtoupper($char)) - ord('A');
            return strtoupper(chr((($k*$x + $s) % $m) + ord('A')));

        }
        

        function getLongest($words)
        {
            $lengths = [];
            foreach ($words as $word) {
                $lengths[] = strlen($word);
            }
            usort($lengths, function($a, $b)
            {
                return $a < $b? 1 : -1;
            });
            return $lengths[0];
        }
        ?>
    </body>

</html>