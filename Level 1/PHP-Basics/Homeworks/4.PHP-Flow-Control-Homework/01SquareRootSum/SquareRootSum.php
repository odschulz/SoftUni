<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Square Root Sum</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css">
	</head>
<body>
<section>
	<table>
		<thead>
			<tr>
				<th>Number</th>
				<th>Square Root</th>
			</tr>
		</thead>
		<tbody>
			<?php
			$sum = 0;
			for ($i = 0; $i < 101 ; $i+=2) : 
				$sqrt = round(sqrt($i), 2);
				$sum += $sqrt;// It is incorrect to round before adding to $sum, but this is according to the problem sample output
			?>

				<tr>
					<td><?php echo $i; ?></td>
					<td><?php echo $sqrt; ?></td>
				</tr>
			<?php endfor; ?>
		</tbody>
		<tfoot>
			<tr>
				<td>Total:</td>
				<td><?php echo $sum; ?></td>
			</tr>
		</tfoot>
	</table>
</section>
</body>
</html>