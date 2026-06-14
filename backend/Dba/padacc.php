<?php
// By 0OMPHALOS @
	date_default_timezone_set('UTC');
	$UserName =(!empty($_POST['n']) ? $_POST['n'] : null);
	$ldatas = (!empty($_POST['u']) ? $_POST['u'] : null);
	$ldatan = (!empty($_POST['a']) ? $_POST['a'] : null);
	$ldataf = (!empty($_POST['f']) ? $_POST['f'] : null);
	if(!empty($UserName) and !empty($ldatas) and !empty($ldatan) and !empty($ldataf)){
		$UserName = strtolower($UserName);
		$spfile = '../Dbu/'.$UserName.'/mdma.p';
		if(file_exists($spfile)){
			chmod($spfile, 0400);
			$pccont = file_get_contents($spfile);
			chmod($spfile, 0000);
			$tmsOTiU = hash('sha256', $ldatas);
			if(hash_equals($tmsOTiU, $pccont)){
				$tmsOTiU = '';
				$pccont = '';
				$tafile = '../Dbu/Pend/'.$ldatan.'/'.$ldataf;
				if(file_exists($tafile)){
					chmod($tafile, 0700);
					if(!file_exists('../Drumkit/'.$ldatan)){
						mkdir('../Drumkit/'.$ldatan, 0755);
					}
					if(rename($tafile, '../Drumkit/'.$ldatan.'/'.$ldataf)){
						echo "Completed.";
					}else{
						echo "Failled.";
					}
				}
			}
		}
	}
	unset($_POST);
?>