<?php

/**
* 
*/
class Seminar
{
	public $seminar;
	public $date;
	public $lecturer;
	public $details;
	
	function __construct($seminar, $date, $lecturer, $details)
	{
		$this->seminar = $seminar;
		$this->date = strtotime($date);
		$this->lecturer = $lecturer;
		$this->details = $details;
	}
}