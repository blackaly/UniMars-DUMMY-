# UniMars

|     Users    |        |    Posts     |        |   Comments   |        |     Likes      |
 -------------           --------------          --------------          ----------------
|  user_id     |        |   post_id    |        |  comment_id  |        |    like_id     |
|  first_name  |        |  user_id     |        |  user_id     |        |    user_id     |
|  last_name   |        |  content     |        |  post_id     |        |    post_id     |
|  email       |        |  image_url   |        |  content     |        |  comment_id    |
|  password    |        |  timestamp   |        |  timestamp   |        |  created_at    |
|  created_at  |        |  likes       |        |  likes_count |        
|  updated_at  |        |  created_at  |        |  created_at  |
|  bio         |        |  updated_at  |        |  updated_at  |
|  location    |        |  user_tags   |        
|  website     |        


|  Followers   |        |  Following   |
 --------------          --------------
|  follower_id |        |  user_id     |
|  followee_id |        |  followee_id |
|  created_at  |        |  created_at  |
        


## This is a database schema for a social media platform. Here's an explanation of each table:

- Users: This table stores information about the users of the social media platform, such as their names, email addresses, passwords, and bios. Each user is identified by a unique user_id.
- Posts: This table stores information about the posts made by users on the social media platform, such as the content of the post, an image URL if the post contains an image, and the timestamp of when the post was created. Each post is identified by a unique post_id, and each post is associated with the user who created it through the user_id field.

- Comments: This table stores information about the comments made on posts by users, such as the content of the comment, the timestamp of when the comment was created, and the number of likes the comment has received. Each comment is identified by a unique comment_id, and each comment is associated with the post it was made on and the user who made it through the post_id and user_id fields, respectively.

- Likes: This table stores information about the likes made by users on posts and comments, such as the timestamp of when the like was created. Each like is identified by a unique like_id, and each like is associated with the post or comment it was made on and the user who made it through the post_id and user_id fields, respectively.

- Followers: This table stores information about the followers of users on the social media platform, such as the follower_id (the user who is following) and the followee_id (the user who is being followed), as well as the timestamp of when the follow relationship was created.

- Following: This table stores information about the users who a particular user is following, such as the user_id (the user who is following) and the followee_id (the user who is being followed), as well as the timestamp of when the follow relationship was created.


___

## Notes;

It may be a good idea to add a **"username"** field to the Users table in order to allow users to create custom usernames for their profiles.

The Posts table should include a field for the number of likes the post has received, in order to avoid having to count the number of likes each time the post is displayed.

The Comments table should include a field for the number of likes the comment has received, in order to avoid having to count the number of likes each time the comment is displayed.

The Likes table should include a field for the type of item being liked (post or comment), in order to differentiate between the two and make it easier to display the appropriate number of likes for each item.

It may be useful to add a "reactions" table that stores information about the different types of reactions (such as "like", "love", "haha", etc.) that users can have to posts and comments. This would allow users to react to posts and comments in a more nuanced way than simply liking them.

The Followers and Following tables could be combined into a single "relationships" table that stores information about all types of relationships between users (followers, following, friends, etc.). This would make it easier to query the database for information about a user's relationships.

It may be useful to add a "tags" table that stores information about tags that users can add to their posts in order to make them more discoverable. This would allow users to search for posts by tag, and would also allow the social media platform to display trending topics based on the most popular tags.

Overall, the schema seems to cover the basic functionality of a social media platform, but there are some additional fields and tables that could be added to make it more robust and flexible.

