Tomorrow is classroom test time. 
The test is on the names of animals and flowers.
Your mom is going to take you out in nature to review…
This area is an animal park where the animals happily play and rest.#C:Mom:1 #POS:2
Child, here are some nutrients. Can you help me feed them to the designated animals?#C:ParkRanger:1 #POS:2
* Sir, this should be your job.#C:You:2 #POS:2
->Response1
* Sorry, I just can't.#C:You:3 #POS:2
->Response2
* Sure, I'd like to practice my English words.#C:You:1 #POS:2
->END
=Response1
I hope you fail that test.#C:ParkRanger:2 #POS:2
Fine, I'll do it.#C:You:2 #POS:2
->END
=Response2
You can do it! I believe in you.#C:ParkRanger:1 #POS:2
I don't believe in myself though. Anyway, I'll give it a try.#C:You:3 #POS:2
->END