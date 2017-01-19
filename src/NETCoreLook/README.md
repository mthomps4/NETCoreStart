# NETCore Look 
Looking into .NETCore and cross platform capabilities. 
Creating a walkthrough for hosting on AWS and/or DigitalOcean. 

Simple Web App Checklist 
- [ ] ASP.NETCore 
- [ ] MVC 
- [ ] Entity Frameworks 
- [ ] DB 
- [ ] Hosting on AWS or DigitalOcean 

### Project Overview Thoughts 
- "E-Commerce" Art Website
- Splash Home Page 
- Details Page per Art piece 
- Add to Cart 
- Shopping Cart w/ total
- Admin User 
- Dashboard for CRUD (new Art Pieces)

#### Models 
- ArtPiece 
- User 
- GuestCart ? 

#### Views 
- Home 
- Details/{ArtPiece}
- ShoppingCart/{GuestCart}

#### Admin Views
- Dashboard
- AddNew 
- Edit 
- Delete 

#### Controllers
- Login 
- Logout 
- AddNew
- Edit 
- Delete 
- Get All Art Pieces 
- Show Piece 
- Add To Cart 
- Get Cart 