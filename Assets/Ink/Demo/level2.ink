Look, your aunt has planted many beautiful flowers in her garden!#C:Mom:1 #POS:2
*These flowers look like her old face.#C:You:2 #POS:2
->ResponseA
*I am not sure...#C:You:3 #POS:2
->ResponseB
*They're so beautiful!#C:You:1 #POS:2
->MomSaying
=ResponseA
Don't be so rude!#C:Mom:2 #POS:2
->MomSaying
=ResponseB
What? Anyway...#C:Mom:1 #POS:2
->MomSaying
=MomSaying
She needs some flowers for her bouquet, can you help pick the right ones for her?#C:Mom:1 #POS:2
*Doesn't she have hands and legs of her own?#C:You:2 #POS:2
->MomSaying2
*Now that you mention it...#C:You:3 #POS:2
->END
*Sure, I'd like to practice my English words.#C:You:1 #POS:2
->END
=MomSaying2
Don't you have the test of your own?#C:Mom:2 #POS:2
Fine, I'll just do it.#C:You:2 #POS:2
->END