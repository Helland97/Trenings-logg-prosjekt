'use client';

import { useEffect, useState } from 'react';

export default function Home() {
  const [health, setHealth] = useState('Loading...');

  useEffect(() => {
    // This fetch runs inside the container → use container DNS
    fetch('http://backend:8080/health')
      .then(res => res.text())
      .then(data => setHealth(data))
      .catch(() => setHealth('Backend unreachable'));
  }, []);

  return (
    <main style={{ padding: '2rem', fontFamily: 'sans-serif' }}>
      <h1>Frontend ↔ Backend Health Check</h1>
      <p>Status: {health}</p>
    </main>
  );
}
