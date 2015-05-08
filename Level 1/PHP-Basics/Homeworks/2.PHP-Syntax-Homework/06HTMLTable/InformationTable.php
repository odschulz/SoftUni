<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="utf-8">
		<title>Information Table</title>
		 <style>
            table, tr, td {
                border: 1px solid black;
                border-collapse: collapse;
                background-color: #28595D;
                color: #FAFAFA;
                padding: 5px;
            }
            
            tr > th {
            	text-align: center;
            }
            
            tr > td:first-of-type {
                text-align: left;
                background-color: #13ADB8;
                color: #FAFAFA;
                font-weight: bold;
            }
            
            tr > td:last-of-type {
                text-align: right;
                background-color: #FAFAFA;
                color: #13ADB8;
            }
        </style>
	</head>

	<body>
		<?php
		$input = array('Name' => 'Gosho', 'Phone number' => '0882-321-423', 
		'Age' => '24', 'Address' => 'Hadji Dimitar ');
		?>
		<section>
			<table>
				<tr><th colspan="2">Information</th></tr>
				<?php foreach ($input as $key => $value): ?>
			    <tr>
			        <td><?php echo $key; ?></td>
			        <td><?php echo $value; ?></td>
			    </tr>
    			<?php endforeach; ?>
			</table>
		</section>
	</body>
</html>