# wewft
Working effectively with feature toggles

# Exercise

This exercise is comprised of multiple steps that build on top of each other. Don't look ahead!
The tests are there to easily run to code. If something is hard to write a test for, don't bother with them. Writing good unit tests is not the focus of this exercise.

<details>
<summary>Step 1</summary>

### Add a new button to the email to go to your orders.

Inspect the code for Emailer and its tests.
Your job is to implement the following change: we want to include a link to our website where you can consult your orders at the bottom of the e-mail.

We want to use a feature flag to introduce this change. You can use our existing *IFeatureToggleManager* abstraction.

</details>

<details>
<summary>Step 2</summary>

### Handle problems gracefully

Oh noes! Someone removed the feature toggle from step 1 from our feature toggle management system.
How does your code react to this scenario? Can you make our infrastructure more robust so we can handle missing feature flags and/or outages of the feature flag infrastructure more gracefully?

</details>


<details>
<summary>Step 3</summary>

### Alternative designs

Can you think of a way to implement this change where the emailer does not need to know about the *IFeatureToggleManager*? 
Work out a single alternative.

</details>
