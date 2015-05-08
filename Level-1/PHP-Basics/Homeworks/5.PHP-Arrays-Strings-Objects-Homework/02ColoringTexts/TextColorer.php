<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Coloring texts</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css"/>
	</head>
<body>

<section>
	<p class="message">Sample input: What a wonderful world!</p>
	<form action="" method="post">	
		<div>
			<textarea name="text" required="required"></textarea>
		</div>
		<input type="submit" value="Color text">
	</form>
	<?php
	if (isset($_POST['text']) && !empty($_POST['text'])) :
		$input = preg_replace('/\s+/', '', $_POST['text']);
		$chars = [];
		$output = '';
		for ($i = 0; $i < strlen($input); $i++) {
			if (ord($input[$i]) % 2 == 0) {
				$chars[] = "<span class=\"red\">{$input[$i]}</span>";
			} else {
				$chars[] = "<span class=\"blue\">{$input[$i]}</span>";
			}
		}
		$output = implode(' ', $chars);
	?>
	<p class="message"><?php echo $output; ?></p>

	<?php endif; ?>
	
</section>

</body>
</html>