<?php
// By 0OMPHALOS @
	date_default_timezone_set('UTC');
	$UserName =(!empty($_POST['n']) ? $_POST['n'] : null);
	$ldatas = (!empty($_POST['u']) ? $_POST['u'] : null);
	if(!empty($UserName) and !empty($ldatas)){
		$UserName = strtolower($UserName);
		$UserPath = "../Dbu/".$UserName;
		if(file_exists($UserPath)){
			$spfile = $UserPath.'/mdma.p';
			if(file_exists($spfile)){
				chmod($spfile, 0700);
				$pccont = file_get_contents($spfile);
				$tmsOTiU = hash('sha256', $ldatas);
				if(hash_equals($tmsOTiU, $pccont)){
					unlink($spfile);
					if(file_exists($UserPath.'/fmdm.p')){
						chmod($UserPath.'/fmdm.p', 0700);
						unlink($UserPath.'/fmdm.p');
					}
				}
			}
		}
	}
	unset($_POST);
?>