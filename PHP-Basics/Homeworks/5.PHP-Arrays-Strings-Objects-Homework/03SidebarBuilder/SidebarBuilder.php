<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Sidebar Builder</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css"/>
	</head>
<body>

<section>

	<article class="message">
		<h1>Sample input:</h1>
		<p><span class="category">categories:</span> Knitting, Cycling, Swimming, Dancing</p>
		<p><span class="category">tags:</span> person, free time, love, peace, protest</p>
		<p><span class="category">months:</span> April, May, June, July</p>
		<hr>
	</article>
	<form action="" method="post">
		<div>
			<label for="categories">Categories</label>
			<input type="text" id="categories" name="categories" required="required">
		</div>
		<div>
			<label for="tags">Tags</label>
			<input type="text" id="tags" name="tags" required="required">
		</div>
		<div>
			<label for="months">Months</label>
			<input type="text" id="months" name="months" required="required">
		</div>
		<input type="submit" value="Generate">
	</form>
	<?php
	if (isset($_POST['categories']) && !empty($_POST['categories']) && 
		isset($_POST['tags']) && !empty($_POST['tags']) &&
		isset($_POST['months']) && !empty($_POST['months'])) :

		$categories = preg_split('/,\s/', $_POST['categories'], -1, PREG_SPLIT_NO_EMPTY);
		$tags = preg_split('/,\s/', $_POST['tags'], -1, PREG_SPLIT_NO_EMPTY);
		$months = preg_split('/,\s/', $_POST['months'], -1, PREG_SPLIT_NO_EMPTY);
	?>
		<aside class="sidebar">
			<nav class="navigation">
				<h2 class="sidebar-header">Categories</h2>
				<ul>
					<?php foreach ($categories as $value): ?>
					<li>
						<a href="#"><?php echo htmlentities($value); ?></a>
					</li>
					<?php endforeach ?>
				</ul>
			</nav>
			<nav class="navigation">
				<h2 class="sidebar-header">Tags</h2>
				<ul>
					<?php foreach ($tags as $value): ?>
					<li>
						<a href="#"><?php echo htmlentities($value); ?></a>
					</li>
					<?php endforeach ?>
				</ul>
			</nav>
			<nav class="navigation">
				<h2 class="sidebar-header">Months</h2>
				<ul>
					<?php foreach ($months as $value): ?>
					<li>
						<a href="#"><?php echo htmlentities($value); ?></a>
					</li>
					<?php endforeach ?>
				</ul>
			</nav>

		</aside>


	<?php endif; ?>
	
</section>

</body>
</html>