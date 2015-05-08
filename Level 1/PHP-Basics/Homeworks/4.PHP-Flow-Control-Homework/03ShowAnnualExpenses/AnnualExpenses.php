<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Annual Expenses</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css"/>
	</head>
<body>

<section>
	<form action="" method="post">
		<label for="input">Enter number of years: </label>
		<input type="text" name="years" id="input">
		<input type="submit" value="Show costs">
	</form>
	<?php if (isset($_POST['years']) && ctype_digit($_POST['years'])) :
		$period = $_POST['years'];
		$curYear = intval(date('Y'));

	?>
		<table>
			<thead>
				<tr>
					<th>Year</th>
					<th>January</th>
					<th>February</th>
					<th>March</th>
					<th>April</th>
					<th>May</th>
					<th>June</th>
					<th>July</th>
					<th>August</th>
					<th>September</th>
					<th>October</th>
					<th>November</th>
					<th>December</th>
					<th>Total:</th>
				</tr>
			</thead>
			<tbody>
				<?php
				for ($year = $curYear; $year > $curYear - $period; $year--) :
					$yearlyExpense = 0;
				?>
					<tr>
						<td><?php echo $year ?></td>
						<?php for ($i=0; $i < 12; $i++) :
							$expense = rand(0,999);
							$yearlyExpense += $expense;
						?> 
							<td><?php echo $expense; ?></td>
						<?php endfor; ?>
						<td><?php echo $yearlyExpense ?></td>
					</tr>
				<?php endfor; ?>
			</tbody>
		</table>
	<?php endif; ?>
</section>
    
</body>
</html>