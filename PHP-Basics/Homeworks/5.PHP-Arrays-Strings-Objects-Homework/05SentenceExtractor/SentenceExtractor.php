<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Sentence Extractor</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css"/>
	</head>
<body>

<section>
	<h1>Sample input:</h1>
	<div class="message">
		<p>This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)</p>
	</div>
	<div class="message">
		<p>is</p>
	</div>
	<form action="" method="post">
		
		<textarea name="text" required="required" placeholder="Enter text"></textarea>
		<input type="text" name="word" required="required" placeholder="Enter word">
		<input type="submit" value="Extract">
	</form>
	<?php
	if (isset($_POST['text']) && !empty($_POST['text']) && isset($_POST['word']) && !empty($_POST['word'])) :
		$text = $_POST['text'];
		$word = $_POST['word'];
		$result = [];
		preg_match_all('/\b[^\.!?]+[\.|!|?]/', $text, $matches);
		foreach ($matches[0] as $sentence) {
			if (preg_match('/\b' . $word . '\b/i', $sentence)) {
				$result[] = $sentence;
			}
		}
	?>
		<div class="message">
			<?php foreach ($result as $sentence) : ?>
			<p><?php echo $sentence; ?></p>
			<?php endforeach; ?>
		</div>
	<?php endif; ?>
	
</section>

</body>
</html>