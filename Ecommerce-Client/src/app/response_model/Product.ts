export interface Product {
  id: number;
  name: string;
  description: string;
  imageUrl: string;
  stockQuantity: number;
  price: number;
  isAvailable: boolean;
  ratings: number;
  categoryId: number;
}
