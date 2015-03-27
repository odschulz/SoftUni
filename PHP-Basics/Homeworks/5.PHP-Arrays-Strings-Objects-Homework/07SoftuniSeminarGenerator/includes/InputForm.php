<section>
	<h1>Sample input:</h1>
	<div class="message">
		<p>Debugging with WordPress-Mario Peshev-28-08-2014 18:00 WordPress is 
			a free and open source blogging tool and a content management system (CMS) based 
			on PHP and MySQL...</p>
		<p>JavaScript with .NET-Pavel Kolev-12-09-2014 17:00 JavaScript (JS) is 
			a dynamic computer programming language. It is most commonly used as part of web 
			browsers, whose implementations allow client-side scripts to interact with the user, 
			control the browser, communicate asynchronously...</p>
		<p>SEO optimization, social networks, digital marketing-Ognyan Mladenov-
			05-07-2014 18:00 Search engine optimization (SEO) is the process of affecting the 
			visibility of a website or a web page in a search engine's "natural" or un-paid 
			("organic") search results. In general, the earlier (or higher ranked on the search 
			results page), and more frequently...</p>
		<p>Basic Game Theory-Georgi Georgiev-16-06-2014 15:00 Game theory is a study 
			of strategic decision making. Specifically, it is "the study of mathematical models of 
			conflict and cooperation between intelligent rational decision-makers". An alternative 
			term suggested "as a more descriptive name for the discipline" is interactive decision 
			theory. Game theory is mainly used in economics...</p>
	</div>
	<form action="" method="post">
		<textarea name="text" required="required" placeholder="Enter seminars"></textarea>
		<label for="sort-by">Sort by:</label>
		<select name="sort-by" id="sort-by">
			<option value="name">Name</option>
			<option value="date">Date</option>
		</select>
		<label for="order-by">Order by:</label>
		<select name="order-by" id="order-by">
			<option value="ascending">Ascending</option>
			<option value="descending">Descending</option>
		</select>
		<input type="submit" value="Generate">
	</form>
</section>