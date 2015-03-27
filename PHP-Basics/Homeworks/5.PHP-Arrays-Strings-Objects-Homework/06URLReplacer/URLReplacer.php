<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>URL Replacer</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css"/>
	</head>
<body>

<section>
	<h1>Sample input:</h1>
	<div class="message">
		<p><?php echo htmlentities('<p>Come and visit the <a href="http://softuni.bg">Software University</a> to master the art of programming. You can always check our <a href="www.softuni.bg/forum">forum</a> if you have any questions.</p>') ?></p>
	</div>
	<form action="" method="post">
		<textarea name="text" required="required" placeholder="Enter text"></textarea>
		<input type="submit" value="Replace">
	</form>
	<?php
	if (isset($_POST['text']) && !empty($_POST['text'])) :
		$text = $_POST['text'];
		$pattern = '/(<\s*a\s*href\s*=\s*\")([^\"]+)(\"[^>]*>)([^<]+)(<\/\s*a\s*>)/';
		preg_match_all($pattern, $text, $matches);
		for ($i = 0; $i < count($matches[0]); $i++) {
			$replacement = '[URL=' . $matches[2][$i] . ']'. $matches[4][$i] . '[/URL]';
			$text = str_replace($matches[0][$i], $replacement, $text);
		}
	?>
	<div class="message">
		<p><?php echo htmlentities($text); ?></p>
	</div>
	<?php endif; ?>
</section>

</body>
</html>