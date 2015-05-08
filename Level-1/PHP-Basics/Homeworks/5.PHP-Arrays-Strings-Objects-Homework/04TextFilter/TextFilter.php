<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Text Filter</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css"/>
	</head>
<body>

<section>
	<h1>Sample input:</h1>
	<div class="message">
		<p>It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! 
		Sincerely, a Windows client</p>
	</div>
	<div class="message">
		<p>Linux, Windows</p>
	</div>
	<form action="" method="post">
		
		<textarea name="text" required="required" placeholder="Enter text"></textarea>
		<input type="text" name="banlist" required="required" placeholder="Enter banlist">
		<input type="submit" value="Filter">
	</form>
	<?php
	if (isset($_POST['text']) && !empty($_POST['text']) && isset($_POST['banlist']) && !empty($_POST['banlist'])) :
		$text = $_POST['text'];
		$banlist = preg_split('/,\s/', $_POST['banlist']);
		foreach ($banlist as $word) {
			$replacement = str_repeat('*', strlen($word));
			$pattern = '/\b' . $word . '\b/i';
			$text = preg_replace($pattern, $replacement, $text);
		}
	?>
	<p class="message"><?php echo $text; ?></p>

	<?php endif; ?>
	
</section>

</body>
</html>