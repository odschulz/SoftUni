<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Most Frequent Tag</title>
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
		$countedTags = array_count_values($tagsArray);
		arsort($countedTags);
		foreach ($countedTags as $tag => $count):?>
			<p>
			<?php echo (htmlentities($tag) . ": " . htmlentities($count) . " times");?>
			</p>
		<?php
		reset($countedTags);
		endforeach; ?>
		<p><?php echo ("Most frequent tag is: " . htmlentities(key($countedTags))); ?></p>
	<?php endif; ?>
	    
</body>
</html>
