/** @type {import('tailwindcss').Config} */
export default {
  content: ["../**/*.{razor,cs}"],
  theme: {
    extend: {
      screens: {
        'xs': '375px',
        'sm': '500px',
        'md': '640px',
        'lg': '768px',
        'xl': '1024px',
        '2xl': '1280px',
        '3xl': '1440px',
        '4xl': '1536px'
      },
      keyframes: {
        wiggleFrames: {
          '0%': { transform: 'rotate(0deg)' },
          '25%': { transform: 'rotate(-5deg)' },
          '50%': { transform: 'rotate(0deg)' },
          '75%': { transform: 'rotate(5deg)' },
          '100%': { transform: 'rotate(0deg)' },
        },
        rotateBorder: {
          to: { '--border-angle': '360deg' },
        }
      },
      animation: {
        'wiggle': 'wiggleFrames 0.25s ease-in-out infinite',
        'rotate-border': 'rotateBorder 3s linear infinite',
      }
    },
  },
  plugins: [],
}