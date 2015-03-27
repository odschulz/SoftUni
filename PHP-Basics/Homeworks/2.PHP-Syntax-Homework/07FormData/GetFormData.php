<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="utf-8">
		<title>Information Table</title>
		 <style>
		 	form {
		 		background: #281F18;
		 		width: 300px;
		 		padding: 5px;
		 	}
		 	
            input[type='text'] {
            	display: block;
            	margin-bottom: 10px;
            	font-size: 16px;
            	padding: 5px;
                border: none;
                background-color: #F5F1D6;
                color: #281F18;
                width: 300px;
                box-sizing: border-box;
            }
            
            input[type='radio'] {
				margin-bottom: 10px;
            }
            
            label {
				color: #F5F1D6;
            }
            
            input[type='submit'] {
				display: block;
            	margin: 0 auto;
            	font-size: 16px;
            	padding: 5px;
                border: none;
                background-color: #F5F1D6;
                color: #281F18;
                width: 25%;
                box-sizing: border-box;
            }
            
            p {
            	background-color: #281F18;
                color: #F5F1D6;
                display: inline-block;
                width: 300px;
                padding: 5px;
            }
            
        </style>
	</head>

	<body>
		<section>
			<form action="" method="get">
				<input type="text" name="name" placeholder="Name" required="required"/>
				<input type="text" name="age" placeholder="Age" required="required"/>
				<input type="radio" name="gender" value="male" id="male-gender" required="required"/>
				<label for="male-gender">Male</label>
				<input type="radio" name="gender" value="female" id="female-gender" required="required"/>
				<label for="female-gender">Female</label>
				<input type="submit" value="Submit"/>
			</form>
				<?php if (isset($_GET['name'], $_GET['age'],$_GET['gender'])):
					$name = $_GET['name'];
        			$age = $_GET['age'];
        			$gender = $_GET['gender'];
    				?>
				<p>
					<?php printf( "My name is %s. I am %s years old. I am %s.",
					htmlentities($name), htmlentities($age),htmlentities($gender))?>
				</p>
				<?php endif; ?>
		</section>
	</body>
</html>