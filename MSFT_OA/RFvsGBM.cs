// Algorithmic difference is; 
// Random Forests are trained with random sample of data 
// (even more randomized cases available like feature randomization) 
// and it trusts randomization to have better generalization performance on out of train set.
// On the other spectrum, 
// Gradient Boosted Trees algorithm additionally tries to
//  find optimal linear combination of trees (assume final model is the weighted 
//  sum of predictions of individual trees) in relation to given train data. 
//  This extra tuning might be deemed as the difference. Note that,
//   there are many variations of those algorithms as well.