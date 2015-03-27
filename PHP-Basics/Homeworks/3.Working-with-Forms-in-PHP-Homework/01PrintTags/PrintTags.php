<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Print Tags</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css"/>
	</head>
<body>

	<form action="" method="post">
		<h1>Enter tags:</h1>
		<p>Pesho, homework, homework, exam, course, PHP</p>
		<input type="text" name="tags">
		<input type="submit">
	</form>

	<?php if (isset($_POST['tags']) && !empty($_POST['tags'])):
		$tagsArray = explode(", ", $_POST['tags']);
		for ($i=0; $i < count($tagsArray); $i++):?>
			<p>
			<?php echo $i . ": " . htmlentities($tagsArray[$i]);?>
			</p>
		<?php endfor; ?>
	<?php endif; ?>
	    
</body>
</html>