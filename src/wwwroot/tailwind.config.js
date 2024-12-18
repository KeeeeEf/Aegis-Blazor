/** @type {import('tailwindcss').Config} */

export default {
  content: ["../**/*.{razor,cs}"],
  theme: {
    extend: {
      animation: {
        "scale-shield-first": "scaleShieldFirst 15s ease-in-out infinite",
        "scale-shield-second": "scaleShieldSecond 15s ease-in-out infinite",
        "scale-shield-third": "scaleShieldThird 15s ease-in-out infinite",
        "rotate-border": "rotateBorder 3s linear infinite",
      },
      keyframes: {
        rotateBorder: {
          to: { "--border-angle": "360deg" },
        },
        scaleShieldFirst: {
          "0%, 100%": {
            backgroundSize: "40% 40%",
          },
          "50%": {
            backgroundSize: "30% 30%",
          },
        },
        scaleShieldSecond: {
          "0%, 100%": {
            backgroundSize: "70% 70%",
          },
          "50%": {
            backgroundSize: "50% 50%",
          },
        },
        scaleShieldThird: {
          "0%, 100%": {
            backgroundSize: "100% 100%",
          },
          "50%": {
            backgroundSize: "75% 75%",
          },
        },
      },
      container: {
        center: true,
        padding: {
          DEFAULT: "min(7.5vw,96px)",
        },
      },
    },
  },
  plugins: [],
};