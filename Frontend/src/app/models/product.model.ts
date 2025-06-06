export interface Product {
  id: number;
  title: string;
  slug: string;
  price: number;
  priceWithTax: number;
  description: string;
  category: Category;
  images: string[];
  creationAt: Date;
  updatedAt: Date;
}

interface Category {
  id: number;
  name: string;
  slug: string;
  image: string;
  creationAt: Date;
  UpdatedAt: Date;
}