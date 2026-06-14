<?php
// By 0OMPHALOS @
	date_default_timezone_set('UTC');
	$UserName =(!empty($_POST['n']) ? $_POST['n'] : null);
	$ldatas = (!empty($_POST['u']) ? $_POST['u'] : null);
	$ldataf = (!empty($_POST['f']) ? $_POST['f'] : null);
	if(!empty($UserName) and !empty($ldatas) and !empty($ldataf)){
		$cnuset = $UserName;
		$UserName = strtolower($UserName);
		$tuserpath = "../Dbu/".$UserName;
		if(file_exists($tuserpath)){
			$spfile = '../Dbu/'.$UserName.'/mdma.p';
			if(file_exists($spfile)){
				chmod($spfile, 0400);
				$pccont = file_get_contents($spfile);
				chmod($spfile, 0000);
				$tmsOTiU = hash('sha256', $ldatas);
				if(hash_equals($tmsOTiU, $pccont)){
					$UserPath = "../Dbu/Pend/".$cnuset;
					if(!file_exists($UserPath)){
						mkdir($UserPath, 0755);
					}
					$OneTimeUn = hash('sha256', rand(101, 999).rand(101,999).rand(101,999).rand(101, 999));
					$tmsOTiUA = hash('sha256', $OneTimeUn);
					$tnkfile = $UserPath = "../Dbu/Pend/".$cnuset."/".$ldataf.".p";
					$fh = fopen($tnkfile, 'w');
					fwrite($fh, $tmsOTiUA);
					fclose($fh);
					chmod($tnkfile, 0000);
					exec("chmod -R 0000 ".$tnkfile);
					echo $OneTimeUn;
				}
			}
		}
	}
	unset($_POST);
?>