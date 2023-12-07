﻿using Logic.Year2023;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.TestYear2023;

[TestClass]
public class TestDay01 : TestBase<Day01>
{
    [DataTestMethod]
    [DataRow("1abc2", "12")]
    [DataRow("pqr3stu8vwx", "38")]
    [DataRow("a1b2c3d4e5f", "15")]
    [DataRow("treb7uchet", "77")]
    [DataRow("1abc2\npqr3stu8vwx\na1b2c3d4e5f\ntreb7uchet", "142")]
    public override void Solution1(string input, string expectedResult)
    {
        Assert.AreEqual(expectedResult, Day.GetSolution1(input));
    }

    [DataTestMethod]
    [DataRow("4nineeightseven2", "42")]
    [DataRow("eightwothree", "83")]
    [DataRow("treb7uchet", "77")]
    //[DataRow("2xjzgsjzfhzhm1\nqhklfjd39rpjxhqtftwopfvrrj2eight\n95btwo\nlfsqldnf3onenplgfxdjzjjnpzfxnineseven\nfive7fouronesevenpfsrmszpc\nxcsfkjqvln2tpm\nncjtcdb625two9\n6srtj3gfghkdtmfzseven\nthree4fournineone\npcpsxmkhdgsix25six6ngzsqzdcrb\n1sixdzhbjvnvgcxmsrlkb9xbjk7t2\ndsxnfkjn2vtwofivethree2\nqfbp2tpgvsxm\nkvbhsseven2rkbllhrhvsevenfour2vf\nbqbtzbtt3\nninek6\n3fivebvqhvhlvz\ntwo68jxfnqlzfkninenine8\nvhckhhhb2sixtftjtdjf2nine\n4jc\n3sevenxlxfnpk\n5sjfive\nc8bvlkdq283rqfftj\n8eight1threehhvmnlft\n4sixmfcronelzcpnfourlgdbkgt\nhntcjmppp9fmntwokx2\n24mkgr6mx9n4\ncksfkrdmdcmnbmkgk3two4\ntwosixthreefivelq3nine\nnjmrtr6fmldninevcbtxr42\neightfrdrczdxrcrfxh6\n8sevenonefmfqhtx8lk\nlnoneight8twodg\ntszrcb7tvvhfive4\nnknphprtv67fivehqlfournine2jk\n9eightszgdhftggrktkzbsmnhtwonekh\n1onefzkgf2two417\n77fivepsmmpp\nbnine7vmttgmdskc\n6tnsixclbvkhmsp\nggreightwo1mnsbzmxsdcdrhhg5one\nninetwo6qtbklgb2\nfour8fmfxmr\nthreetxfrsevenvfdgrtsixtwofsq7\nhqxlseven53\nvxqq24eight6\n7psxpgxmkpzkzeight3\n9four7\nstwoone4eightwoj\none38\n9cjlrgrgpfjeighteightdcpjhzbjqcdthree\nrqfone2\ndvkxhvkgxcfivescjcnqqnnine2tthreecptkgxmzjsbzdrhk\n5lhprmg8two7two3\n5lvtg5sevennine2zrrmghf4seven\nfourfive97sevensevensixcsffnlcbtjk\nonesixoneninesixnbkf5xpsgsmpvdsdsqdvpjjzp\nnineb321mgkpqjqjqh\nseven2cstttkvkmpssflkxjmbnvthreefour\nsix1bmcjbhdgqm6kgzsxbgdqnjqf3four6\nzchkfjxsllkncz175\nvsveightwo8\nfourbtrnfdp2four5\n13dtf8769\n6qfvvdqdrtstwothree4seven8vszpseven\n7rgzpxfbczk1fivetwo4two9nine\n3sksmfxn\n16ninetwonqqmptq\n9five4fckzssxsvpzbvlktjzcninethree\n3threel889bvbcgvl\nthreetzzjntxlsd2klrjfnbg87\n3two3qrrdbkbk\n29oneightt\n7mkpfchstjt7mshqht4fivesix\ntvmqndvsix875nine8\nvg7477ninecpnrvnine7\nseveneightmknlqjlstx4zjjrpbhjhnnc8\n8qklthreetwo7tlmrfzvtwo7zvccc\n6one1dpstqpmfbhst\nsixfourfourseven6rzdkfour\n6eighttbltmntb8\nseven72cqslvzpgj\njpvrsgfhtwo5nfc1cgxdrdrbfnseven\nfour1ninezlhqxtsgfzsevenhspvmxrtztzgtmseven5\nfoursixzjvgjgsevensvkd5\nseven121fivefgxhdfive\ntwoh8\nghhtttxqgr95\nzkpklcjbjlr2\nnine2mtrdcbrbntrdqninevbkbfg35lnpx\nnineninesix68pcvsdnns\nrf16one7\nseven276\nsixseven1\nqjxseven9six\n7c9xvhgmpf41\ndlzpvdpxseven9nine\nmlmlqrpn4twofivesbmhdbcsixtwo\nld74txfzksr5qconenine\nsix7djcdrtk7chktrh88\n2seven7jtrbhznt\n1eighthnhchsevenfive\nqdhscpeight8\n12gnxzzm\nk7fourmhcfkggt8919np\n8zljspvnmlx6four\n36twofivethreeptbdrfqzbz7qbjm\nbxkbjbzgone3ldhlnhxfcf7btkktspxrtqkxqfdmlqgqvgclb\nsevenfourmdrxseven2z2fiveone\n8bbprzqrqn\ntwofivethree95mpqclhfkzlsix\ngpfjflrkc96tmsix6dxjnfive\nqzeight6\nfive5zlthgqjntwotqmnnsd\neight6nbpvfour4kzkvbzrxcmkh\nfdkrxdckqbpsklz64fourones8\n5qpldkhltl\n27xldkbqbnmrrbqkhmksvk\npjoneightknpcgkkv7cbknrhfdmtdm8\n432xsixvvktflzxone\n35fouronemzzszfqppllgchsjjnine\nqgcnzcbvsxbtn6lthreenineone\ntwo2fourkdgbfb\nfzkmbtvnvj5bzfgvxv3nineknpqzznzmf\n9mkqtmlnpzt282dgkmvlsonefourthree\nmcqhpkhonethreeninesevenfdsggqnlfcnrft3frqzkscft\n847\ngsxvvr6tghfbxxghgv6lplf\nfqzgkxkbmkpbhpvpdprmlhsngc5\nqeightwo2threecrjjtv9fourbthree\n2eightdcbgfdqzk\nfourtwothree5tdzpzfxkpjmlkzzrf\nseven633\n8mldn\neightmg7dvjzbngkxmnxdctjtdffive97zpjrjqvp\nsixfournineone38eighteight\n8mngs412\n3fivefourtwo7five\n7sevenjfkcf7rvone8xjdvsc\ntljcrzngfdsqctfour6hsnljsxrqdzd\ncsix7hnkhds4four67\n3cxrlqcnseven4twox3\nrtwonerxcnpqdnzksvzmmndcjlzq2nine6ntfzjdqnrjeight\nzbqgrvvvblggbghtfx98\nthree2zcpspgtq77vqtgpcxkvq8\n94zksixnvbxrllxln\n1eightrctknxkmv9jtwoeight\n2onenine5eight58\nfour2five\n6fourfiveeight\npbfourlzdl4\n4onejrltvhxprhlzctrqzbz5fourseven6\nhlsdjlleightdcmdj8jdg\neightbfkgvbxxm6\nsixseven9hmhchsmqhhtrdftcfivetz\nmq4five2fsdhzn\nceight3mncgnineeight8dkqrjjtmc\nonefour7eightsix\nseven4fqsjk38fhbmn9fgzzcc\n9cmb5ninenjsppthpnine5\nqghtvpsqpxptoneljvstwo8lpqcbgtqvjmpq\nonelq85dlqpx8\n1threetzsxqtndvhqn\nlqdvkonebqjqj9\n3six6\n9two9sixeight776\nscrrprfkblkplgqzzqb2\n18vcrhxb4b\nthree8nine\n1khkncj8fivefourthree2\nninetwo8tbbsfmkqtt51five\n66one88\nninempgbhpm6seven34\neightthreetwo4threetwo\nvvpqkdonesevendvfrgmhhlsix91threethree\nvbskcncpjxtdhqlcone6kgqpz\n54lmnnqsrm73\n5mqnmvcbqnz82ninethree\n47teightthreehrhtdndrk\nfft2foursrdhxkzfourv\ntbeight48759eight9twonenl\n3sfkvkmvbbm9four9cbjzgllfl\nsixqhxeightone7tlsd\n22zmllbhcptwo\ndqxdjrkmnvkbsxc3ztbseven\noneeight6dcphmnrfltfour\nmgxzcfsevenfour4six\nsixb8six34gqjtlcq\nfiveseventhreexfblvxgkplvbrgpfive1onesix\none3mgqphj5\n7fpzxmmxgnb5\njbshclzone3oneseven117dkzzdxdd\n56five1\njeightwo1ninemxtvgl717pbv1mqs\n3six36\n35mlzjsgxxtg\nhmmjgonehjqdcqkh1gskjrmfour7\neightfiverqbb3\nsixtdkfbglhbjbvthreejsd8tglkrsfktcjt\n1eight2mgxrgbbb3\nzzqxvtthreepf3eighttwoonefive\nvjnxhl4threetwokj\noneqddgbbqtzsonenxkeightvx7\nnine24\nftwone2\n53twonehx\ntwo7three4fourhbgninenkvxjjsz\n7five62ninefour\n53nine7lqthree4\n1six1jn\nfive5drcjvbgdxzonefourfjdkfive\n6onecfninesqfdtxmdhmfvlhbsjv9eight\n5dqmfmqbdfdjvpl\nqxkqfjshdone2zrmdsts\n1qrvnf8zvfour\ndht2\n4twoqdrshn87vxldzvnkn1five\n4nineh\nzctqdcfbseven6three58lzscrpsbb2\nfzmndhssmm3jdzlfourshjkmjkv53gvssnvzsz\nfive2qkxtfkj3sixshpnzdcjhlcmksnv\nbskcmljnq69\npsxkxqztb3xsctsk6qvldjdzzqmgqcxncx2btqxh\nonetwosixttghndtzx8\n8twocmnfmslsheighthtxsgjddm\nfnvkqndfqmhgscnvq31kvvftxbzhtgzxqtngvqseven\n7sevenkhhvtvsbrvcvm8zksvgcfrkgfourtzjvpqstckmmlzz\n7hkfiveeightpjhone\n8zptwoonemrninefive3spxrlhr\n3qvjknqcnngpkninecgsbp3sevenfnpvrcltj\nqztwo8678\nbxkj959dntcpzv\n4one4\nlstwone347nine\nff79krfbjttqp4seven1\ngjtlbgxdqt7eightsix\n8fivefour82threetwo\n1zjxthree4\nszgx6fivefour12\n557dspnfzhmlh\n5hnfour\n847zzkrtjlb\n82six\nxlnhrcksv3fourzl\n2ninetwo8ninelhnsbseven9\nccseightwo8fiveonetwo5onegkhlg\neightp2onegrmfsnine5one\n4five9xnmlldfive\nfive636\nfivesix29\n34dsbtmlhgggzkqxs7\ntwothreesmgjch93mcdndsn\ncmnmtzjnmtggseven1tjsshnktffive72\n7xcbpsix6m\n7fourthree\n7cxnzthree\n5eightthree3lpvlfk\n4rdnp\none6gmpjfouronettbbjdqsxn\n6xtcv\ndpspd1cb2onegxsgdtcsix\n1eightpseven\nntczqmrclm2\nsix7nineeight1\nqrndlfour9bhbmlgj6\n52vhnxvngjjkzt\nnine8six\n3seventhreesixfpmpbjninesix\nseightwoseven4sevenppdnk7\nlnxeightbhxfmdrxcbjzx9sixnine\n8ptdmjrd21zrnt1one\none1dmbfournine2\n25five748\n266eightwom\nzxfxjn32threelxmqnlcvnknzbn3\nlqmjm2onezseven\nsphlhbbz14sixtwosix\nsixr9llqxb4\ntnnhlmsix314mqvdlxfour4\nthreenjxgtthreethreeeight14one\n1fivetwo\nhhhtkpvhvg8\n31cslxxzgbktjtwotrzs1one\ntwoseven9\n4fivenine9332\nsix35nineeightwok\nnine9fpxgqjrftwovhldfflqthree\n434four5threetpcs\nql52kzzgnsgll\nonex5145\ngsppnkx1\n22six\nzjbbqnbhsdfourmk19sixone\nsix3onesevensixvnsixone7\nseventhreefive8\nfour62four7eightseventwo\n2three5jtzmtxhqxhsixxlkmptshb\nfive3lklnccst1dstgvnprktgcnseven\nsevenfour52\nhfxkkbcfpcgzfqsv1three68three\nlnqrcdpglf2ksqddhp\n13onenbmqvpqsbbf\n1bfive\n1dmnlscgvfdqrf\nbvtwonettkzzxpb4\n5two2t7\nt7djkh\n63t86nlhfgqgnrghqone1\none89eightlmztkcjjnonefive\n7twosjmcrlcfqr29lfkrjz\n1nine5four\nxxjbmsvfxb8\nnxvrvcqkbseven99rbzbdp641\n56fdpx\nskszhkqdtonesixth5eight\nninetwo8jqbtwokbhzvv4fiveoneightxb\n1threemfcblxjljdtone\nfsfgncxvcmszn2pzspkkgqvfxlnbzgjr1\nrrxhnslrkeightgcsbcgdbkplzxbmmlxsn5sfp66\nfoureight3\n5rplrmrjtjcfnct9sixfourzptmffrpthree\nmld6ztzninesixfour4\ntwohbbxmthljpkqthtcgtt8\nltvgmqgsix89\n6khclqhcvdz24eightseven\n6prb\nnhsjqtnk6bqzhzvldlcgsmkq1twobfqzm\ntfivehmdtxqlsevenzxt1ckjbnttgqctwo4\nghnjjmtlvfive9znltjfskfnl3vdcjkvqcdplvdmckmfgxq\nztvvbbjx3\n6jhsrszlpsh\n4fhtrctvrgmfhdjqvqp8sixnnftggrzlgs2\nbvlqxnjbbjgtfpslpspvpl7jsjlrdfiveeight88\nfsvcxvlc74sevenltx37sevenlbq\nfourfivetgkqz5cgj4\ncnrjtfvht74nptvh\noneldnoneone745dhvqnvmlfj\n2trhmdcpnreight\ndshghlkjzh1kv\nthreexzkssrxlzzpxsjzbbtthree7\neightdsqrdllssxv7sevendttwo3three\nstz6five9four\njfbfgvfgmvlhjv94\nrcncncfcqsevenjdrtctbbsznpct48cbbxseven\nninevjxzk2two\n1qgdcpslvqhjzbgtsbnzcd\nkmlzbndds8fivegfdgpfivetwo63\n66mkeightnine1rvfnine4\nnine82\n58ntpkdssixnntjlgfkxq\n2jxqttctsxthreepnxsfive\nfivekvfkqpc28foursixptgbpfm6\n6twofourslqbzlcsmf\nfive4vmdl\nthx5six\n5hfnsqhvcfgckcseven3jgdtkkv\nseven6eight65five99\nhplrgdqrjtonesevenseven4z65eight\nkhkts8hcsfvhvqjv9eightnine48\npqxztthreeninelxhcxkjclk2\nsixrmfpj6nine4zx\n9xtvxkxpjv9\ncmtggbrckmmzffncttxsevenhphmhfgjsr85\n83s4\n26fivefivethreemstzpncmhfm\n87eightfourgvmmfbknineone\nbdxg2zszhcgtvtseventhmbvfive\nzeight8\neight78dcnq4jtz\n67csrthree\n3vqxtwonerts\n1five3\nsevensixfournineksxkz9bkbgcrjjjhnineeight\n8seven29\n9394\npkqxvl9vbjmqblrksjqcshpzpfrfouroneeightnine\nheightwolgpplrbnhrgdkrk25crttkkzkbt\n6659eighttwoone\n55lzqzng2dmtpq45\n512gpmqpsqfive9eight\neightsnxz58zrbh8fiveeight\nsix893ninerrxzj\ntwoflrzzcgninefqqlmmzzqgnjrcxcfour5ninetlcmc\ntmfkbgcssdcmkthmx1seven\n6three9fourmdpzj\nmgprpn68\nxssxrtpntlkppxp958rzd2nine8\nfx15twoeighttfjlcglnbptwo66\nthreeseven522\nxrjpstjr2\n6eight1742oneighthhj\n1ddfkgjrxfzrhnxtnvfqxdv4\n8hlcxdpkrnrgfzmsschlhcbndkcvdszgqntl\nfive154sixfourqgffh\n5rsvtzgrvq1slrlgqksone6lns\n92sevenk3xfrvgddsthree4\nrctlcz67\n2nmrbhnzpf7\nbjmssix1sevenfour4\n744ninefivefivejjcnpgrqxtrctwo\nr4five4\n16two2\nthreefn8\n3gmsrqtjm\none8tmlnlqvgfone5fivefive\n1spllmone9three1xsssk5\n6rlqqblbrxh8\n41qqccnsevengbbrpgcqggtlhtzqcfqzhtx\nhzfivethreenine2\nsixeightvcm4lngvkdlpz6dstz\ntwoeight34tv1\ntgqc6fqsftwoninexncjnrtcgcbrxdmnine\n8one27ninerjt3seven\n1sjvxlzszhhsix\n2xxmpjsfbr\n7eight5eight5bzgdpkkpgrn\ntwozcrxdsix1lrxltrhvznine7twoone\n8qlfive8nlmthree39\n4five5five7671\n4fiveqtrngqtbpd74\nvbccfjhjndeight1h\n8kfzchkdvfgvlhqzfgseven\n6ninexrxsvlmmzrsevenjhzzggfcxqrvfjtnjctveight9\n6fourfourfourxgrgqklnpcsjbsqvhnkjfcjdhdf\n65fpnfszb3\nsrnhthmpseven1four3rrpznf\nvgmqr9zttpdrzjfiveninesevendfive\nfournthreesevenseven72seven\n9594\ntwolhvpfzbfsfourrrcpzzshd66grxddrmkvthree\nseven5twotwolpsqlbcqpthree\n29eightzjgsfmll\ngtkrjrsevenfbjcpjlsmqsfceightseven9\nqkbntcjvfl6three9qhpcptvpkfour7b\ngvkhmrljmhrpj956bzxhkljpvpxltctjvvpfjtsnb\nrcqlnpcmng6l5vfkpddeightsevenfhmxzztndq\nsptdrlsfxpsxff4five\nlrzhhxdrkdtbdjbsfourthreemmjjnn1\n9sxthreethree\nsix9fourseven4\ndpone9fshbbpcm8\ntwoczqzvqkcnine6eight\nqbtkgxp1fourdz\ndxrrsdbmtpnl6hfdtj\nsixsvtwo8\n5fxdkhbgqm8fouronefive5\njqj6lhtbjt\n6pdgrsdxghfkhptbjcrrjcsevenbksvmzvnninercz\n8rzqvh6ntlg2bfktcphztdkckjg7two\nfivesixnine1\n4beightsevenonetwothree8jx\nsixfourmvpk6fourtgknrjmxfftnmngjnine9\n68seventwosnqsj\ng853seven7\n7ninejqslxmkxpbkxksjcjlnttslpcmsprvgnrxg\njmvqrhdcctwofivev6eightone\nninefiveseven9eighthbb7two\nthreethreethreerlgqzvsevenx3eight\nxbkvgdsrhknine3blt\nxzbcgjkkbk1two1zprpn3bcxxhlxjtx7eight\n3tflfncljtwo9\nfour3seven8one6\nsix7vqfive\nddhhgvrkzfhone8\nfqtbnbvdvbklnkmpr89twotwo4\n9two166eight4cfnsstwo\ntwofive88\nnxpmbfiveeightqmtblmtzpjcnxnxjtwosixtwo9\nfourthreefivedone9jzhrbrzmdqkzmqzfklxq\nqbgpfsvlx1eightjsevensixfour\n2sevenfqkeight2five\nsqnsvsevenrbkhgkbhmmqjztzvn3sevennkcghqqcckp\neighthcrzxpjt1eightone\nsixone2\nfour56zqxr1lcmblzgdgqjnqb\nq6hdldzmjh6ninevjm9\nj82onek67\n5njnffiveshlbqpqhzt\n97nineoneightcq\nffivetwo41vnzhfqmrd4\ntwo2fiveone1nftfhvzkpltvn4three\ntwofivethree7jlsjxgjfbvnlxhb\nrmb4fourlmzgvfcsgn2five\n6dthkxkcdbssixdlrb38\nqgbnpdpchmnnftqpeight9xlmlskqhc156drhpf\nsevensixsevenjqckcmg6sixxtgvrvm2sgtvrjrq\n4nnhmghrqrkcmfmqxtqxncljskfvmhfmgqfour\ndlpqjk2fivesix7\nonegtddk5vzgpndqp2five\nqsslgone4onelbnbckznrfnjmsgz\npvqdbhjgqrgbqkzgpdbmvninekhvfrmpchhxm2\ntpxvskgzgnnvmnfncvqxxtkmm75vfgmxr4zbpdmdseven\nssnqndqxsevenxztmfq64\nmcxmhtnbczdfnstjn31six\ntwosixfz5jvbxxlhdklbp1\nfive4six952\nvmnhjm3rzgglnmzj318\ndcnprh12qnmmqnvhkrhtrnxs5\n5b\nmkfgxmvsixeight5\ncrzdkbjthreeone287fourpgzqldn\n2cgdd\nseven8oneeightllqtfbdtmdnvlcsfh5\n4seven1zqponeeightlplm\nc7sevendvmxlfpnr6\neightlkhjgqj6\nnjvmgjdmx2\n9six7\n3cfbjptcp5one8four\neight6kxc8one\n6sevenlpbdcgbhxsixfourseven7\n4sixeightsix9hq\n6eightb\n8eight86jkrdgmxdfourthree\n4dxczptzbvjfive56eight\nseven3threerpqhsqspsdpvxj2sevensndcxn\nzqcbcseventwo4gh16jksxkphgf\n44tfour7br\nfive266five93seven1\nprsbtlbninendbpzv5xx5\n6three2nqgtrlkfxn\nninefourxkrsgshmdd78six7nine\ngnkphdvhqk74fptcqgp\ncfdmp2\nfzhhdclzncxmg26nineeight4\nseventworlcqhfq2qrfiveqqgmmzdpntfm\nonedvsbvstdshtlzs6sixfive\nqjfbtdtcknthreeeightsix71\n2ninesixscdxtwo\nthreerlpjxlzsr9qqzmfbzdtnknn2four\n8kxxljngrqsgkxcnlhrlxxfgl57fql7\nvhrjlgqjnnthree4four8fivebfourffcnbghnz\n5jb5oneoneonebseven\nkbkv3three4rgdkdzkrkk\neightxhxzkbhjxsvfsjfbzghktvlqhseven2xkslcrfsgdc\nsevenone6rmkcvfour6jhvhz\nthreenhfprcngzhcqckchphcninecmqvczqt5\nfoureight6\n7fkrgmdrxgdkfpvxkns9\n5onetwoqnp\nnine73dbfljgnninecdgxrgkdlsqzflbtwo\nfive3jcsevenfour8sevenjgfxkfgnlzbkb\nlqtvkrfour67gdnrhkfvzgfoureightone\nkct1pljt8seven\nsix269two\n64k\n41ggbblvhs726\nmbvfq5gghsxtwomngfczfdpb1seven\n4ggzmdpbkrczhmmrk5\n317\npxtgbfnfhqgncrsgtf7sixfour\ndvqnfourcsnmcxnxq7ghmjbgmct\nvnskfrdcjdoneddjpkcj7fourjjlllonepxlpjkzbzfour\nhbdjzfbvrthreekxmlkm49\ntrptone5bpsxgl\n5one1\nsixsixfzgbninecxssl9\nsix7xdnsdgsix4\nfivefive84fxrzgk4eight81\nzszvqhms8sstxvfz\n3one3sixbmxbfsdbdtmh\nqnfgnjgcv6two57\n5676xzlbzk485seven\nfive8dbbtpxctf\ntwo1gntvjr\n77one\nvlnkqvczts5tkghpvthree6krgszgx4\nnine2threefoureight\nfoursevenhc3twofour\n9zzgqfzmfpsfn\nghb57sixeightwofqc\n6twovninejckdhmcsxkfoursix5\noneqxljxjhnineppln419\none2zlfsxrkfourthreexl7\nnqbtczpblq856one6\n3cxmmzlh1\nfrjsdskzk79lcxvjqqdnlqsmbpbdxrxthreeseven\ntwoone457fivetbq4\nfourtvbdksxsjxzgdk77\nfourgbvdlpbgztwoftmkjkkmthreesix1\nnhrqfbzggrskfgmnbg7sevenfzrnlxfbtc\nfoursevenmdrnfqsn4jvnrntwo29\nfivevzvszgqvqp6627zqnk\n15fcvczdlqprxjzhgbxpxs5\n9fourfivejsgvnf9five\nkzlndjrn8rgq\nspfqqx3sevenoneldqnqbmspvsixfiveninezmvks\noneseven5\n2eightfour5bqbmsnhmtfivebss\nninejnckkvseven4\njzhfcmvb8fiveqgq18fivevlpgdnkbq\n67four\ngrzpdtl9\nlzf8fivedr2fivevbpldcone\nnine4bdfptdffgkssltwopl\neightlvgfhfbsqrdjrskqkprdlltnzzpfhnczsonetwo5eight\n7xqfgzglblftvsqqbgpfmthreesix9jfl2\neightgngsvqvrhgmvhtqhbpdeightfour6\n1bqvpnggbdrfoureightxmclfpfqgjssrpflnzl\neightfive1qvhhthk9ninetwo\nsix36fourfivefivezsvndsl5four\njnpzplgbqf6tlzpsgvzhtnkdvhzhbvhps5\ncldz3bfpvdxjmc\ndpponeseven48sevennineeightrkn\nfive3fournine\n2xcckljnjz98mjjscfjsxsevenqhxrqvqmbvhzgkc\nsixtwo66469\n79four5eight\njxqktt47\neight36\nrsjlmlj5oneightc\nxczzpjknphtspmh7eightvfzjjk2five\nkmznfcxhsn8fivethreexnineone2\nfour6six\n2hhnine627\neightnine1vkdpgvxgm\n8three6pvtqmfdxdkxps\n7frnthree\n78tworhldxeighttphp\ndcmv6vvfbzjdtphbpssjnnqdmrgzgkfdveightwov\nzsbmctdseven1snxmqxzgsix9\nlxtwo4sevenxsix\ntkdkqfpj5eightq8two447\nseven1onesixfivest\n45six5sevenseven\njpxxdjphzskpbrllninexmmmdxrznzthreecvsmjssmfxczhm5\n4flhfqlphfcnn9sevenx3\n16ttrmgqninefsgvkt5four\n3snfkm\n6threetwoglgkbqjlsn4fivehcgfour\nninesixfive1ninelgdmhkqrvn\ntwo3pxvlsheight\ntwo51\nsixninezkbfbxgzznlgtpxgcpzvgkczdbfive8three\nfourjljzqgbsthreeqjdgsqpspnsixxnglmkss5m\n32sevenctqtqrqlsfourfoursixrcjztxx\n8qlccjngpt\n2eight58five\n1ninesevenxtlbrq6\n9fivevkmm8tgxfkzvgq\n53txg\n3xqmjvxkcbjf2\n2fhndgqnqd5\n2vnrpjdb6four79\n7four5\nfoursix5hdcg489ninerncnk\n6s2jd\nfournine8ninejn6rkknh5\nfcfxflzv7seven7\n1fournineqzknrvfhdxfoureight4seveneightwobr\n1two3\ntwombl5\nfourzjh9six\n1ljrvbrqpcchb\n11rvqfmcxgg\nfiveoneggjpmdt2t\nnnjdzhdrkvhpxnprlfrhxpbtpbdxm1xfshdr\nfive39threehhrhsrhhqkjt9\nhm8nine\n3ldckgksm48xc2seven8gbzfq\nsixqpcqjzqxsjhr7\nkthreethreelmjfour485\nmnggrsbbnh1\nxfn5\nqzlxtczqlvninekjnbnonefcbqqgfmqf66xpvjgfzjgxvjrcqmzx\nkrsfvctzfhonejxtqbbnd7eight\ntjhgbtqtwoljone9\nmdfntzfpg1fiveninecvxrfnine2\n7hcrxzc\n6two6plgrmbnine9sdbvgtnj\nthreenine4fthstfjzzp\n6eighteight9npghczggthreectqssdtp\nflc4gtqsjmrddx8eightseven\nthreeone1oneone7\ngfbfjzltcjfkkrsprgtpfive4\nsixrdzp2onesevenrqrtldnq4c\nsevenktwo3threeeightthreenhnmpdmlqjnvl\n4eight82717\nnrhqqkmkeightthreenzqbgcphoneseven7\ntwoprrgggznzffour5bbrdsvtgkkrbl5nlrkpjmnbzgsbtl\n28pvjrszmrdntp4nqdnhkdrtwoxr\nsixsix9five4\nlxchg91threethree74\n6bmxblxdkghqdjqgqbrqtxknvdsevenztgspsfh83\n39bsspvhslzkmrnzxtlxsbhk4\n74seveneight9ninedgzgjdvxgvrnfz\nfourxvvqsfktptjbsb69\nrxsevenfive5vx9\n72six7\nfive5lcxv2jvsssxqjtmzclfdfourfive\n87three9\n6rckksfour413331\n33gtz\nxkmxtvzhgxqqmknn9pzhgjxqseight\n8threefivedrtlgrnqfouroneq\n6snzkxjcfive62dqtqmtwoxnine\nzxtjclonefour1eight5eight1\nqlffthreeseven2three\nxfppngbg5six3two8nine\nninesevensevencfhppvhdnfour8\nxhvnm1\n9threecbdccktrkfourfour9twoneqd\n1five4fivenine\njcscpdtzk757nine8\nsevenninesixxkzzzbfour2three\nsixthreetwovfqxtbvcrrjtwo3four9\nnzdjhtlqfnxmrzvgrzkfmm7mhmvbbxfd\n3seven2eight99\ntwo6nineljvxs5eightseven3\n55fivezgbmcdpv\nhkgvvrtrtwopjbqhtts8seven\nc138\nmnrnhqtzthreesnnj2\n81\nqscxbblvsxsgtcpr4cphmxgmbrb\n4six2mrvdpxqvhngrrzhjdjfp\n4tmrlmdfivefivethree7\n363\n8488one\n827pcxnhpk\nckbdqdvhdd4hrb9nnghltwo\n5onecjjfdfrxppqkhrpthree5lr4\n62lvlsp2sixfive5\nczxfkhcbvcdhdzx2\njzdgngb68\nfourtwo18pxkttcr8four\nbkttjvvmxvzkhmxtpqrxxhslstwo6five22\nfour26mcvb2fivepone\ndzptwo5ninejgjrfour\nnrhqqnjfour9four\nffoneightpxp41six\nthreeninehzmrh8dzvmpgrhsv\n5onefour5\njdl5fourtwo8\nthreefour8seventwo1seven\nlvkjd6five6fxkfthxkgmfour6\nthree3seventhreepbsgc\n7threethree6fgmfgcv6glrk\nnine3five\n54one9\njhvqhrvqfrfgpdrh3three5\n3psztbfour4\nnlffive1nxcqpfour232\n3threetwosgsbdjnt\ndtfstb1qhggj\nqnnp9twojdg4kfzvtbsevenfour\nqfnmdkfkpndd36sixsixfourseven\n8seven7oneseven9x4five\n4847onetgmsbjjqhtfiveksmmlftk\nfivesixlklrnhtdfg3\ncpcqone1pnxkhrkdhhzheightlpb5three\neighttwo6\nseven2fourfourvfzxqbh7\nfrf1fivesix3snnlpgpc7\nsvtvfcsevenhszznbzpfiveeight2\nlqpqzthree5mcmzpqlxkgpssix\n9sltfzqsczpjbndmqbccgmq\n5six9fourxppzkgbj6\n8dqhklnxseven1\n3two4\nktvlhmq3xzmcztbplxlqzpqmoneightffd\n76dklx7two8nine5vgvh\nxmgjgfz4\ntwo7tcnceight9\nninecvfgpbrqcgvplt32six\ng3rcbzqxnjllqoneklpbjzbqbseven\nsvkf8ggdnmeighthhjlz3four\nhfdb44zqjmxbrft3qrpgvjngc1\ndzsbnsrg35tm\nqchpdcg2\n9775fcg91\ngdrhdgmfdk77eight\n14bsixthreeseven\ntwo1twoninepkkvhlzlt3\nkvslhphhj9fourvljqbfive\n8nc6\nqg7six\n7vkgv8\ntd5fivefive\nxvfour8jttrsvvjkkdxxzjsl\n7qbgdfkj4fourfivenmqtfmgeight\neightfourdzxpfggzxcqrmtxnggchlqtwokcnrdhqf1\nlbhcptlfhflgthreefive9cpprdlbv\nnine7941cfxnxszfivebm\nninenhgpj7fourfour9\n456xg\nninethreesqdp11four32lgdl\n38trrgt7\ntnhhxlm3rvzvxmmcgpxm\noneqtmg25snbgzfhtkq8hdlvszrclcsrhqsdn\n3cjndzmkfx\nclxvdv7seven\nfive6three1\n8sixfour36seven9mlxmrx7\nvdrk27jnrbrvdrnine2nvnlkcszoneightchk\n67drgjqrqdktplq\n36pprvngxrrjtnpffmrxxdl\nhkkrgxtpvzzmcrfcbcjzbpnvls88hrxl\nb4jkeightsevenmxkdpvdpt857\n6eighteight2four\neights73five\nfiveslpjvzjlpvzone41nine\nsmnmlrxx7\nonesixfive4\n8s75eightone\n1fivecpqsxm\n99743ninesix\ntwopzflcvxsgzn1v8\n9three49\ntwo2sevenf8sixvdpxzgxbmkrz2\nsevenfive6shhbqhgqqhstdrnfxsjtjvnine\nkzqsvn29s\nthreenlrrhz4ttqljvr\nqx9sfdx\nnhsbgsvvp7\n876eightfivetprjjbxhzbfpqgltt1\nsix3xdjtphrm1pbjvjfn\nnflcpmjpt6six9two6xvbmbm\nfmlglbgmhvseven4nnkkgcmbv9chmthxvztgsevenbtzs\n7bkmchf4five\nxgglktnbeight183twonine\nonecbpdv9\nfhhmddrnlnkvlb5drtcbrjprzcqlj7mgspc\n7threexkfjklvzcfourtnrgmpveightfour8\n6rhmcblhfourtwo3two\none4fiveonenine\nslksfchvlgblninefszfbksddgvd4\nfour742sbseven3lk\n8qbchrfldtvppv6fourzfivez\nninephsmnnvsfour1\none5kvcrtnc5sixonehjfxnsixfqhzjj\n8drgrzngh\n16eight8rczbjmblhn\nthreejpgjbpfdbvgdpftwo96\nsfkhvjgd2smgfkr9two27\nthreeqpdeight3\nthreesevenxblrmqkvzvrbhsix4\n9seven2vlhsninenvptdvmrpzbrlpfhfnl\nxkjpdpgsrtvlfg1eight\nseven254\nthree8fnmcfhrdtjdlpfqlqhgx\n21bkjv54s8\n82ddfour6vcggxhlmpfivesix\ncdsbgtpqthreefivel8nine\n5five5cksct7bvjbtdjkcz\n64fhm\ntqk5\n3mhzkhtfzscpgfctfskdn2five\ncvmvthreez8fivegvcbsxj35nfxdshqz\nsevenqlqmkhdjpmsjrtggqzfive35scmnfpmhmp\nsixfive2\n6sevensvqhhfivetwo\neightthree84\n82six8\n8bbhrkzgtg59cpgdvb\n11three3hfjkvmsl\nqdljkm792\neightgq5xgskvtpgmhxsnhzlqhnksxflvx\nghdhv1seventhree55fourthreemrlhq\noneonethree3zm\n3twobsxqfsfnine\neightsbznkpzsqqtpxfhlfr5\nsevenchs2twoeight\nninezjtxp7bpzdgtoneeightoneighth\nfmkbvzzgvl46fiveoneightqn\nkvsonevxtmmxnfour4lpxjrbcfoursixp\n391onelktkfd1three2twonels\npn2\n3cmsmfvjchflngkrbtsfrblltwo\neightfour8ninesix29\ndpdvnonefour2eightbzzrvthmkgfcdv5\n59sfiverboneone3\n6xrqq1\n9bczfbfbhkntmdmseven68\nnpqm35qszmptx\nfivepkdlmonefivesixz252\ndzrtwonetbbv9twovrsp\nfpkfourfivendkhz6five\n86dknvgcnmcslmztwo3\nfivetxrrzjpb6tqseightjthnhn\n362zhtxdgvcdgnzv55\neightsevenbllbgvdonethreeprglpjhxhqfdn6csnghrtl\n5fourc\n8fournine3svdlh5sevenoneighttsq\neightjkqmgljpprcpblvrthreeseven8fourone7\nvqrqlhmb9seven231vbfzrrstwohjvdjgg\nkk1foursixeight849\nseven13ttbnlr21\njfgsksrrkjsixsixthreesixfourrbxqzdhc9\n3fiveeightqbndjdg6pmftqshone\nnineoneseventkdpztbkk83two4\ncjdbxhpzr87eight\ntwosevenkkdhf86sevendzhvkrttjljr\n67cdltmnbkktzseightsix7two\nthree44zqtglqcffrkmhsgjfive\ntwoonenbf74three9tthsvmngcx\nlvrnpvmvgvnnonesix5\nnchcfxxphmnqbhfourxnine52sixj\nfourqpvngjszftg88seven\nxgzmv133zvjmlfqhcmjbqzfntkjtpdjlkmv\nfivejxc4threebzqbhrldsf\nglvtpvnsevenqvrtcgjkhkcsix1seven\nsjeightwo4fivesevensixnqxsjckfive\nz5\njxxhsmdvkglljhxzxljqz9zplmslcfdxxljtwosixkjxlsrfcx\nfiversdslrkcqclzb7zdzlbllfkvphfqhnfour\nfive1hpdncfpzhdxrhnv4lblgthree7snj\n8scqf\nthreepcfkrhstmsbfvqxsxrctwo185six\n7lqvpqxbjrv9nine985\neight16jvfqcgbmhdgdltxz9\nthree8vncqf9\nzrzp9sevenxthpsxtdninebmnhgrkdjqqjfffourblbkch\nfiveseven25snpsnjgnfl\nninefourxrtdlb1threefivefive1rbqzfbxtst\nthree8three7five41\ntcnvsevenz45fngtjljh\ntxvpst1\neighthrlbmtk4nssknqmxjvjnqsqlfivekzrphrtwo\ntwo492ninekcjvllckdtkp\n48vlvmkcvbsfoursix8\neight28sixsix3nine45\njkm8hhqfclneightjlpsnck8dcvlvgkrfprflsvlh\n4zxjqlfn\nfivebpqfjtcmlsixfour48onejqhzgtftrvkknngf\ndkfour7fivezzsjdbnvgninefivenine5\ntwoxjqldtk91eightneight\nseven57177\ngpbqvlpxvnzgninefoureightthree5\nbzprbrninesnjpgqthreeeightsixtgmvrthfour4\n83brtxx4zzxsxrcfivebzbxlsl\nthreesevenninetwo8twoone\nveightwochrmfrkrcppxkj4tvvzmhqjhnjvtq1threegtmfnnjpxb\n3zgqpvq9krslgjgkjmtbsbhbjg\n4nine8mhfs67vhdjvsjrlz2\nnine659xrvhhnnbqq7\nbninetwoeight8fxntpdkrfp9eightnb\nqtwonecvbgxqfiveoneeight4five\nseven926\nshkkksn4onefivethree\neightsevenqvfqmzqsfn1\nsixdgjmtk5fivevqbxxdzrjqdtgnnffzmfqxzjdzhp\nstsjcmzbxt1\nrvnone3three9twozchp26\nninefmpkdlvzfivetwo1\nfour4one4vdpgp9lprtqjzmhk\n15rpdhczznrzclfcsxdx41\nseven36twopnvjdxrss5\n46ninenine\n6jg8xtqfmjffdlfhzrn\n2jsixfive573\ntwo8eight39fbqkdzseven9\n3gnrg5\nhlkk1\n1sevenfive7\n72jvdqmlrddk\nninetwo8hzdninesixnjhgrcsttwo\n23cxdccvvjrjfsixlcrmxjkeight\n6brqjfjsix56nine3\nninezveighttwogc5two\nninexskpsth5sevennine\nc7jmmjcv\n89sixthreeeight71q\nfivekccfngmxseven7onernfskqnqfive5\nsevensixone4hfhgs\nxq2jxddpdm3nine8ptqlm4\nsmsevendj19fbqdjpznfourgqq6\n7147\nznqbfmcpd4twoseven\nfhcsmxtdx6\nsxj2tcb92\n6nine6\nqdfknmdzt88\n66threebsndqlkrshfive5\neight7pckdhlqzrx24\n3ninevk\nsevennine3\n8one1rjtnhjx\neightthree3ninekzhtlqsevenssprmrqhhgncrs\n6one8nlzxfxvr\n4cgm9fivethree\nfour77gxvdqztzzgbsxhntwortndzqzj\nt8three335\nc2rjggzl\njjgjbqgbnz4gdsqk66991\nninezckbpsr9\njb5sevenseven\none5nfdcvx\n1kbcmclhrh1onejzft\nfiveninefivedglztnjxblonehfive3\n6onesixh6onethree9\nspdzhnt5tpzrkh1fxlnine4skgzdln\n1onenineqgzcq2eightwonh\nvfzvds826vtlrcg6rvseven\nvqmoneight9tknqtcsmb\nkqrcrqrqjbdeight7ckhr23\noneeight2\n8eightnhtqcggtxc6dfsfcjfpznmsthree\nsxfvfdkff8dvlmbdktsixmzpnxzmml2\n9lgmxktj1frxl","281")]
    public override void Solution2(string input, string expectedResult)
    {
        Assert.AreEqual(expectedResult, Day.GetSolution2(input));
    }
}
