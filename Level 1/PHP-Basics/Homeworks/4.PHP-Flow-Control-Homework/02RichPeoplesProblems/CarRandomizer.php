<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Mo money mo probles</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css">
	</head>
<body>
<section>
	<div>Sample input: Mitsubishi, Maseratti, Maybach</div>
	<hr>
	<form action="" method="post">
		<label for="input-field">Enter cars</label>
		<input type="text" name="cars" id="input-field" required>
		<input type="submit" value="Show result">
	</form>
	<?php
	if (isset($_POST['cars']) && !empty($_POST['cars'])) :
		$cars = preg_split('/[,\s]+/', trim($_POST['cars']));
		$colors = ['red', 'green', 'blue', 'black', 'white', 'yellow', 'grey'];

	?>
		<table>
			<thead>
				<tr>
					<th>Car</th>
					<th>Color</th>
					<th>Count</th>
				</tr>
			</thead>
			<tbody>
			<?php
			foreach ($cars as $value): 
				$randColor = $colors[rand(0, count($colors) - 1)];
				$randCount = rand(1, 5);
			?>
				<tr>
					<td> <?php echo htmlentities($value); ?></td>
					<td> <?php echo $randColor; ?></td>
					<td> <?php echo $randCount; ?></td>
				</tr>
			<?php endforeach; ?>
			</tbody>
		</table>
	<?php endif; ?>
</section>
</body>
</html>