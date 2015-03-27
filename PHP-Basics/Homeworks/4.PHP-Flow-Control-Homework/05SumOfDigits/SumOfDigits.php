<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Sum of Digits</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css">
	</head>
<body>
<section>
	<div>Sample input: 1111, 2222, 3333, asdf</div>
	<hr>
	<form action="" method="post">
		<label for="input">Input string:</label>
		<input type="text" name="input-string" id="input" required>
		<input type="submit">
	</form>
	<?php
	if (isset($_POST['input-string']) && !empty($_POST['input-string'])) :
		$input = preg_split('/[,\s]+/', trim($_POST['input-string']));

	?>
		<table>
			<tbody>
			<?php
			foreach ($input as $value):
				$sum = '';
				if (ctype_digit($value)) {
					$sum = array_sum(str_split($value));
				} else {
					$sum = 'I cannot sum that!';
				}
			?>
				<tr>
					<td> <?php echo htmlentities($value); ?></td>
					<td> <?php echo $sum; ?></td>
				</tr>
			<?php endforeach; ?>
			</tbody>
		</table>
	<?php endif; ?>
</section>
</body>
</html>