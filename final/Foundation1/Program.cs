using System;

class Program
{
    static void Main(string[] args)
    {
        // The program class calls 3 instances of the Video class. Then for each video the Comment class instances add 3-4 comments to each video that was created.
        
        Video vid1 = new Video("Product 1 Review!", "James Hunt", 365);

        vid1.DisplayVidInfo();

        Comment comment1A = new Comment("Jack", "Great video, loved it bro!");
        Comment comment2A = new Comment("Jerry Seinfeld Twin", "I wish you could have tested the product more, overall not a great review.");
        Comment comment3A = new Comment("AnonGirl", "I think your product reviews are great! Can't wait for the next one!");

        vid1.AddComment(comment1A);
        vid1.AddComment(comment2A);
        vid1.AddComment(comment3A);

        vid1.DisplayAllComments();

        
        Video vid2 = new Video("Product 2 Review!", "William Henly", 457);

        vid2.DisplayVidInfo();

        Comment comment1B = new Comment("MichaelB", "Your review does not go into enough specifics of the product's capabilities! Did not love your video!");
        Comment comment2B = new Comment("CoolDragon777", "Your style of reviewing is not a good representation of the product to consumers! Please reevaluate how you review these products for your viewers!");
        Comment comment3B = new Comment("HomerSimpson#1", "Your review is honestly lazy and a waste of my time.");

        vid2.AddComment(comment1B);
        vid2.AddComment(comment2B);
        vid2.AddComment(comment3B);

        vid2.DisplayAllComments();

        
        Video vid3 = new Video("Product 3 Review!", "Bart Simpson", 700);

        vid3.DisplayVidInfo();

        Comment comment1C = new Comment("Damian Wayne", "I loved your review! It was so specific and demonstrative of the product and it's uses. Also it perfectly demonstrated its full capabilities!");
        Comment comment2C = new Comment("Sarah Kelly", "Great Review! Thanks for sharing your video!");
        Comment comment3C = new Comment("Zara Madison", "Your reviews are always the best!");
        Comment comment4C = new Comment("Lana Del Rey", "Although I don't love this product, your reviews are great demonstrations of each product!");

        vid3.AddComment(comment1C);
        vid3.AddComment(comment2C);
        vid3.AddComment(comment3C);
        vid3.AddComment(comment4C);

        vid3.DisplayAllComments();
    }
}