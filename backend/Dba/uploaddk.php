<?php
// By 0OMPHALOS @
	date_default_timezone_set('UTC');
	$UserName =(!empty($_GET['n']) ? $_GET['n'] : null);
	$ldatas = (!empty($_GET['u']) ? $_GET['u'] : null);
	if(!empty($UserName) and !empty($ldatas)){
		$cnuset = $UserName;
		$UserName = strtolower($UserName);
		$tuserpath = "../Dbu/".$UserName;
		if(file_exists($tuserpath)){
			$spfile = '../Dbu/Pend/'.$cnuset.'/'.$_FILES["file"]["name"].'.p';
			if(file_exists($spfile)){
				chmod($spfile, 0700);
				$pccont = file_get_contents($spfile);
				unlink($spfile);
				$tmsOTiU = hash('sha256', $ldatas);
				if(hash_equals($tmsOTiU, $pccont)){
					$UserPath = "../Dbu/Pend/".$cnuset;
					if(!empty($_FILES["file"])){
						$target_file = $UserPath . "/" . basename($_FILES["file"]["name"]);
						$fileNameNew = $_FILES["file"]["name"];
						move_uploaded_file($_FILES["file"]["tmp_name"],$UserPath . "/" .$fileNameNew);
						echo "Completed.";
					}
				}
			}
		}
	}
	unset($_POST, $_GET);
?>