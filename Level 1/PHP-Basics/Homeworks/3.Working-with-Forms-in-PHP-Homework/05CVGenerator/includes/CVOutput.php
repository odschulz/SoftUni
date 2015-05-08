<?php
if (!$_SESSION) {
	die;
}
?>
<section id="CV">
	<h1>CV</h1>
	<table>
		<thead>
			<tr>
				<th colspan="2">Personal Information</th>
			</tr>
		</thead>
		<tbody>
			<tr>
				<td>First Name</td>
				<td><?php echo $_SESSION['fName']; ?></td>
			</tr>
			<tr>
				<td>Last Name</td>
				<td><?php echo $_SESSION['lName']; ?></td>
			</tr>
			<tr>
				<td>Email</td>
				<td><?php echo $_SESSION['email']; ?></td>
			</tr>
			<tr>
				<td>Phone Number</td>
				<td><?php echo $_SESSION['phone']; ?></td>
			</tr>
			<tr>
				<td>Gender</td>
				<td><?php echo $_SESSION['gender']; ?></td>
			</tr>
			<tr>
				<td>Birth Date</td>
				<td><?php echo $_SESSION['bdate']; ?></td>
			</tr>
			<tr>
				<td>Nationality</td>
				<td><?php echo $_SESSION['nationality']; ?></td>
			</tr>
		</tbody>
	</table>

	<table>
		<thead>
			<tr>
				<th colspan="2">Last Work Position</th>
			</tr>
		</thead>
		<tbody>
			<tr>
				<td>Company Name</td>
				<td><?php echo $_SESSION['companyName']; ?></td>
			</tr>
			<tr>
				<td>From</td>
				<td><?php echo $_SESSION['fromDate']; ?></td>
			</tr>
			<tr>
				<td>To</td>
				<td><?php echo $_SESSION['toDate']; ?></td>
			</tr>
		</tbody>
	</table>

	<table>
		<thead>
			<tr>
				<th colspan="2">Computer Skills</th>
			</tr>
		</thead>
		<tbody>
			<tr>
				<td>Programming Languages</td>
				<td>
					<table>
						<thead>
							<tr>
								<th>Language</th>
								<th>Skill Level</th>
							</tr>
						</thead>
						<tbody>
						<?php
						for ($i = 0; $i < count($_SESSION['progLangs']); $i++): ?>
							<?php if (!empty($_SESSION['progLangs'][$i])): ?>
								<tr>
									<td><?php echo htmlentities($_SESSION['progLangs'][$i]); ?></td>
									<td><?php echo htmlentities($_SESSION['progLangsLevel'][$i]); ?></td>
								</tr>
							<?php endif ?>
						<?php endfor; ?>
						</tbody>
					</table>
				</td>
			</tr>
		</tbody>
	</table>

	<table>
		<thead>
			<tr>
				<th colspan="2">Other Skills</th>
			</tr>
		</thead>
		<tbody>
			<tr>
				<td>Languages</td>
				<td>
					<table>
						<thead>
							<tr>
								<th>Language</th>
								<th>Comprehension</th>
								<th>Reading</th>
								<th>Writing</th>
							</tr>
						</thead>
						<tbody>
						<?php
						for ($i = 0; $i < count($_SESSION['langs']); $i++): ?>
							<?php if (!empty($_SESSION['langs'][$i]) && !empty($_SESSION['langsComprehension'][$i]) &&
							!empty($_SESSION['langsReading'][$i]) && !empty($_SESSION['langsWriting'][$i])): ?>
								<tr>
									<td><?php echo htmlentities($_SESSION['langs'][$i]); ?></td>
									<td><?php echo htmlentities($_SESSION['langsComprehension'][$i]); ?></td>
									<td><?php echo htmlentities($_SESSION['langsReading'][$i]); ?></td>
									<td><?php echo htmlentities($_SESSION['langsWriting'][$i]); ?></td>
								</tr>
							<?php endif ?>
						<?php endfor; ?>
						</tbody>
					</table>
				</td>
			</tr>
			<tr>
				<td>Driver's License</td>
				<?php if (empty($_SESSION['driving'][0])): ?>
					<td> <?php echo 'No' ?></td>
				<?php else: ?>
					<td><?php echo htmlentities(implode(", ", $_SESSION['driving'])); ?></td>
				<?php endif; ?>
			</tr>
		</tbody>
	</table>
</section>