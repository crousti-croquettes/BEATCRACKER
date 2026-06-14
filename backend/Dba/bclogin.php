<?php
 @ exec("chmod -R 0400 ".$nfilet);
	date_default_timezone_set('UTC');
    $UserName = (isset($_POST['n']) ? $_POST['n'] : null);
	$ldatas = (isset($_POST['p']) ? $_POST['p'] : null);
	$ldatac = (isset($_POST['t']) ? $_POST['t'] : null);
	$tipaddr = $_SERVER["REMOTE_ADDR"];
	$tmpip = hash('sha256', $tipaddr);
	$nfilei = "iprb/".$tmpip.".i";
	if(file_exists($nfilei)){
		$ipchkr = file_get_contents($nfilei);
		$tipadd = explode("|", $ipchkr)[0];
		$ttimip = explode("|", $ipchkr)[1];
	}else{
		$tipadd = 0;
	}
	if($tipadd < 7){
		if(!empty($UserName) and !empty($ldatas) and !empty($ldatac)){
			$UserName = strtolower($UserName);
			$UserPath = "../Dbu/".$UserName;
			if(file_exists($UserPath)){
				$tmsd = date("j");
				$tmsm = date("n");
				$tmsy = date("Y");
				$tmtdata = $ldatac;
				if(strpos($tmtdata, '|') !== false){
					$tmgsfd = explode('|', $tmtdata)[0];
					if(strpos($tmgsfd, ':') !== false){
						$tmgd = explode(':', $tmgsfd)[0];
						$tmgm = explode(':', $tmgsfd)[1];
						$tmgy = explode(':', $tmgsfd)[2];
						$tmfixo = $tmgd -1;
					}else{
						$tmgd = "32";
						$tmgm = "32";
						$tmgy = "32";
					}
				}else{
					$tmgd = "32";
					$tmgm = "32";
					$tmgy = "32";
				}
				if($tmgd == $tmsd and $tmgm == $tmsm and $tmgy == $tmsy or $tmfixo == $tmsd and $tmgm == $tmsm and $tmgy == $tmsy){
					$tfilei = $UserPath.'/tiap.p';
					if(file_exists($tfilei)){
						chmod($tfilei, 0700);
						$grted = file_get_contents($tfilei);
						chmod($tfilei, 0000);
					}else{
						$grted = "_";
					}
					$chpit = $tmpip."|".$ldatac;
					if(strpos($grted, $chpit) !== false){
						$fip = fopen($nfilei, 'w');
						fwrite($fip, $tipadd + "1"."|".date("h:i:s"));
						fclose($fip);
					}else{
						/*$tmsd = date("j");
						$lines_arr = preg_split(PHP_EOL,$grted);
						$num_newlines = count($lines_arr);
						for ($x = 0; $x <= $num_newlines; $x++) {
							$ERG = $grted[$x];
							$ARG = $ERG(explode())
							if($grted[$x]===""){
								
							}
						} */
						$spfile = $UserPath.'/pass.pass';
						if(file_exists($spfile)){
							chmod($spfile, 0400);
							$pccont = file_get_contents($spfile);
							chmod($spfile, 0000);
							$tmtsp = hash('sha256', $ldatas);
						}else{
							$pccont = "0000000";
						}
						if(hash_equals($tmtsp, $pccont)){
							if($UserName === "andreasaa"){
								$oadmun = hash('sha256', rand(101, 999).rand(101,999).rand(101,999).rand(101, 999));
								$tamdk = $UserPath."/fmdm.p";
								$fa = fopen($tamdk, 'w');
								fwrite($fa, $oadmun);
								fclose($fa);
								$oadmun = "";
								chmod($tamdk, 0000);
							}
							$OneTimeUn = hash('sha256', rand(101, 999).rand(101,999).rand(101,999).rand(101, 999));
							$tmsOTiU = hash('sha256', $OneTimeUn);
							$nfileu = $UserPath."/mdma.p";
							if(file_exists($nfileu)){
								chmod($nfileu, 0700);
							}							
							$fh = fopen($nfileu, 'w');
							fwrite($fh, $tmsOTiU);
							fclose($fh);
							if(file_exists($tfilei)){
								chmod($tfilei, 0700);
								$ft = fopen($tfilei, 'w');
								fwrite($ft, $chpit.PHP_EOL.$grted);
								fclose($ft);
							}else{
								$ft = fopen($tfilei, 'w');
								fwrite($ft, $chpit);
								fclose($ft);
							}
							chmod($nfileu, 0000);
							chmod($tfilei, 0000);
							if(file_exists($nfilei)){
								unlink($nfilei);
							}
							echo 'Completed|'.$OneTimeUn;
							unset($OneTimeUn, $tmsOTiU, $spfile, $pccont, $wtfile);
						}else{
							if(file_exists($tfilei)){
								chmod($tfilei, 0000);
							}
							$fip = fopen($nfilei, 'w');
							fwrite($fip, $tipadd + "1"."|".date("h:i:s"));
							fclose($fip);
							echo "WrongPass";
						}
					}
				}else{
					$fip = fopen($nfilei, 'w');
					fwrite($fip, $tipadd + "1"."|".date("h:i:s"));
					fclose($fip);
					echo "Packet";
				}
			}else{
				$fip = fopen($nfilei, 'w');
				fwrite($fip, $tipadd + "1"."|".date("h:i:s"));
				fclose($fip);
				echo "lExists";
			}
		}else{
			$fip = fopen($nfilei, 'w');
			fwrite($fip, $tipadd + "1"."|".date("h:i:s"));
			fclose($fip);
		}
	}else{
		//Server date
		$ttfsm = explode(":", date("h:i:s"))[1];
		$ttfsh = explode(":", date("h:i:s"))[0];
		//IP banned date
		$tcimim = explode(":", $ttimip)[1];
		$tcimih = explode(":", $ttimip)[0];
		//Math
		if($ttfsh - $tcimih > 1){
			unlink($nfilei);
		}else{
			$tfileb = 60 - $tcimim;
			$tservd = 60 - $ttfsm;
			if(($tservd - $tfileb) < 0 or $tservd > $tfileb or $ttfsm > $tcimim){
				unlink($nfilei);
			}
		}
	}
	unset($_POST);
?>