<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>HTML Tags Counter</title>
	</head>
<body>

<?php
	session_start();
	$output = "";
	if (!isset($_SESSION['score'])) {
			$_SESSION['score'] = 0;
		}
	if (isset($_POST['tag'])) {
		$htmlTags = array('!DOCTYPE', 'a', 'abbr', 'acronym', 'address', 'applet', 'area', 'article', 'aside', 'audio', 'b', 'base', 'basefont', 'bdi', 'bdo', 'big', 'blockquote', 'body', 'br', 'button', 'canvas', 'caption', 'center', 'cite', 'code', 'col', 'colgroup', 'datalist', 'dd', 'del', 'details', 'dfn', 'dialog', 'dir', 'div', 'dl', 'dt', 'em', 'embed', 'fieldset', 'figcaption', 'figure', 'font', 'footer', 'form', 'frame', 'frameset', 'head', 'header', 'hgroup', 'h1', 'h6', 'hr', 'html', 'i', 'iframe', 'img', 'input', 'ins', 'kbd', 'keygen', 'label', 'legend', 'li', 'link', 'main', 'map', 'mark', 'menu', 'menuitem', 'meta', 'meter', 'nav', 'noframes', 'noscript', 'object', 'ol', 'optgroup', 'option', 'output', 'p', 'param', 'pre', 'progress', 'q', 'rp', 'rt', 'ruby', 's', 'samp', 'script', 'section', 'select', 'small', 'source', 'span', 'strike', 'strong', 'style', 'sub', 'summary', 'sup', 'table', 'tbody', 'td', 'textarea', 'tfoot', 'th', 'thead', 'time', 'title', 'tr', 'track', 'tt', 'u', 'ul', 'var', 'video', 'wbr');
		$currentTag = preg_replace("/\W+/", "", $_POST['tag']);
		if (in_array($currentTag, $htmlTags)) {
			$_SESSION['score'] ++;
			$output = "Valid HTML tag!";
		} else {
			$output = "Invalid HTML tag!";
		}
	}
?>

	<form action="" method="post">
		<label for="tag">Enter HTML Tags:</label>
		<input type="text" name="tag" id="tag">
		<input type="submit">
	</form>
	<h1><?php echo $output?></h1>
	<h2>Score: <?php echo $_SESSION['score'];?></h2>


</body>
</html>