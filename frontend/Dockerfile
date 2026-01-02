# 1. Base image
FROM node:20-alpine AS base
WORKDIR /app

# 2. Install dependencies
COPY package.json package-lock.json* ./
RUN npm install

# 3. Copy source
COPY . .

# 4. Build Next.js
RUN npm run build

# 5. Run Next.js
EXPOSE 3000
CMD ["npm", "start"]
