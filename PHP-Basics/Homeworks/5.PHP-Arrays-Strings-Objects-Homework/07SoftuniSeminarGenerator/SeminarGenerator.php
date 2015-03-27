<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>SoftUni Seminar Generator</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css"/>
	</head>
<body>

<?php
require 'includes/Seminar.php';
require 'includes/InputForm.php';
date_default_timezone_set ('Europe/Sofia');
session_start();

if (isset($_POST['text']) && !empty($_POST['text'])) :
	$text = $_POST['text'];
	$pattern = '/([^-]+)\s*-\s*([^-]+)\s*-\s*(\d{2}-\d{2}-\d{4}\s+\d{2}:\d{2})(.*)/';
	$sortBy = $_POST['sort-by'];
	$orderBy = $_POST['order-by'];
	preg_match_all($pattern, $text, $matches);
	$seminars = [];
	for ($i = 0; $i < count($matches[0]); $i++) { 
		$seminar = new Seminar(trim($matches[1][$i]), trim($matches[3][$i]), 
			trim($matches[2][$i]), trim($matches[4][$i]));
		$seminars[] = $seminar;
	}

	usort($seminars, function($a, $b) use ($sortBy, $orderBy)
	{
		if ($sortBy == 'name') {
			if ($orderBy == 'ascending') {
				return strcmp($a->seminar, $b->seminar);
			} else {
				return strcmp($b->seminar, $a->seminar);
			}
		} else {
			if ($orderBy == 'ascending') {
				return $a->date > $b->date ? 1 : -1;
			} else {
				return $a->date < $b->date ? 1 : -1;
			}
		}
	});

	?>
	<section>
		<table>
			<thead>
				<tr>
					<th>Seminar name</th>
					<th>Date</th>
					<th>Participate</th>
				</tr>
			</thead>
			<tbody>
				<?php foreach ($seminars as $seminar): ?>
					<tr>
						<td>
							<a href="#" class="seminar"><?php echo htmlentities($seminar->seminar); ?>
								<div class="tooltip">
									<p><span class="title">Lecturer:</span><span><?php echo htmlentities($seminar->lecturer); ?></span></p>
									<p><span class="title">Details:</span><span><?php echo htmlentities($seminar->details); ?></span></p>
								</div>
							</a>
							
						</td>
						<td><?php echo date('d-m-Y H:i', $seminar->date); ?></td>
						<td><button>SIGN UP</button></td>
					</tr>
				<?php endforeach ?>
				
			</tbody>
		</table>
		
	</section>
	<?php for ($i = 0; $i < 15; $i++) : ?>
		<br>
	<?php endfor; ?>
<?php endif; ?>

<script type="text/javascript" src="scripts/tooltip.js"></script>
</body>
</html>