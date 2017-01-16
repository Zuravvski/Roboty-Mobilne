﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace robotymobilne_projekt.GUI.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private Geometry logo;

        #region const
        public static readonly Geometry serverDisconnected = Geometry.Parse("M49.5,38c0-3.859-3.14-7-7-7s-7,3.141-7,7v1h-4v18h22V39h-4V38z M37.5,38c0-2.757,2.243-5,5-5s5,2.243,5,5v1h-10V38z M51.5,41v14h-18V41h2h14H51.5z M41.5,51.858V53c0,0.553,0.448,1,1,1s1-0.447,1-1v-1.142c1.72-0.447,3-1.999,3-3.858c0-2.206-1.794-4-4-4s-4,1.794-4,4 C38.5,49.859,39.78,51.411,41.5,51.858z M42.5,46c1.103,0,2,0.897,2,2s-0.897,2-2,2s-2-0.897-2-2S41.397,46,42.5,46z M53.354,8.51C52.197,4.22,43.578,0,28.5,0S4.803,4.22,3.646,8.51C3.562,8.657,3.5,8.818,3.5,9v0.5v12V22v11.5V34v12 c0,0.161,0.042,0.313,0.115,0.448c1.139,4.833,10.691,7.68,19.811,8.364c0.025,0.002,0.051,0.003,0.076,0.003 c0.519,0,0.957-0.399,0.996-0.925c0.042-0.551-0.372-1.031-0.922-1.072C12.461,51.984,5.984,48.6,5.532,45.838 C5.524,45.793,5.514,45.75,5.5,45.707v-8.414c0.018,0.016,0.039,0.032,0.057,0.048c0.232,0.205,0.47,0.409,0.738,0.605 C10.067,40.791,17.595,43,28.5,43c0.552,0,1-0.447,1-1s-0.448-1-1-1c-0.827,0-1.637-0.016-2.432-0.044 c-0.482-0.018-0.947-0.049-1.417-0.076c-0.297-0.017-0.603-0.028-0.895-0.049c-0.624-0.045-1.23-0.103-1.829-0.165 c-0.12-0.013-0.246-0.021-0.365-0.034c-0.686-0.075-1.354-0.161-2.005-0.256c-0.024-0.003-0.049-0.006-0.072-0.009 c-3.379-0.499-6.279-1.26-8.548-2.165c-0.017-0.007-0.035-0.013-0.051-0.02c-0.414-0.167-0.803-0.338-1.174-0.514 c-0.047-0.022-0.097-0.044-0.144-0.067c-0.333-0.16-0.64-0.325-0.935-0.491c-0.073-0.042-0.15-0.083-0.221-0.125 c-0.256-0.15-0.49-0.304-0.714-0.458c-0.089-0.062-0.18-0.123-0.263-0.185c-0.188-0.139-0.358-0.28-0.52-0.421 c-0.092-0.08-0.183-0.16-0.266-0.241C6.516,35.551,6.4,35.422,6.29,35.293c-0.08-0.094-0.156-0.188-0.224-0.283 c-0.087-0.121-0.161-0.242-0.227-0.363c-0.055-0.101-0.104-0.202-0.146-0.303c-0.048-0.119-0.086-0.238-0.114-0.356 C5.541,33.825,5.5,33.662,5.5,33.5v-8.207c0.018,0.016,0.039,0.032,0.057,0.048c0.232,0.205,0.47,0.409,0.738,0.605 C10.067,28.791,17.595,31,28.5,31c10.88,0,18.396-2.199,22.177-5.034c0.29-0.212,0.55-0.431,0.799-0.653 c0.008-0.007,0.017-0.014,0.024-0.021V34c0,0.553,0.448,1,1,1s1-0.447,1-1V22v-0.5v-12V9C53.5,8.818,53.438,8.657,53.354,8.51z M51.5,13.293V21.5c0,0.163-0.041,0.327-0.08,0.491c-0.028,0.117-0.065,0.233-0.112,0.351c-0.042,0.103-0.092,0.206-0.148,0.309 c-0.066,0.119-0.138,0.238-0.223,0.357c-0.069,0.096-0.147,0.192-0.228,0.289c-0.108,0.127-0.223,0.254-0.353,0.38 c-0.085,0.083-0.178,0.165-0.272,0.247c-0.16,0.139-0.327,0.278-0.513,0.415c-0.086,0.064-0.18,0.127-0.271,0.19 c-0.222,0.153-0.453,0.305-0.706,0.453c-0.074,0.044-0.153,0.087-0.23,0.13c-0.292,0.165-0.597,0.328-0.926,0.487 c-0.049,0.023-0.103,0.047-0.153,0.071c-0.369,0.174-0.754,0.345-1.166,0.51c-0.019,0.007-0.039,0.015-0.058,0.022 c-2.269,0.904-5.166,1.665-8.543,2.164c-0.024,0.003-0.05,0.006-0.074,0.01c-0.651,0.095-1.318,0.181-2.003,0.256 c-0.12,0.013-0.246,0.022-0.367,0.034c-0.599,0.062-1.204,0.12-1.827,0.165c-0.293,0.021-0.599,0.032-0.897,0.049 c-0.469,0.027-0.934,0.059-1.416,0.076C30.137,28.984,29.327,29,28.5,29s-1.637-0.016-2.432-0.044 c-0.482-0.018-0.947-0.049-1.417-0.076c-0.297-0.017-0.603-0.028-0.895-0.049c-0.624-0.045-1.23-0.103-1.829-0.165 c-0.12-0.013-0.246-0.021-0.365-0.034c-0.686-0.075-1.354-0.161-2.005-0.256c-0.024-0.003-0.049-0.006-0.072-0.009 c-3.379-0.499-6.279-1.26-8.548-2.165c-0.017-0.007-0.035-0.013-0.051-0.02c-0.414-0.167-0.803-0.338-1.174-0.514 c-0.047-0.022-0.097-0.044-0.144-0.067c-0.333-0.16-0.64-0.325-0.935-0.491c-0.073-0.042-0.15-0.083-0.221-0.125 c-0.256-0.15-0.49-0.304-0.714-0.458c-0.089-0.062-0.18-0.123-0.263-0.185c-0.188-0.139-0.358-0.28-0.52-0.421 c-0.092-0.08-0.183-0.16-0.266-0.241C6.516,23.551,6.4,23.422,6.29,23.293c-0.08-0.094-0.156-0.188-0.224-0.283 c-0.087-0.121-0.161-0.242-0.227-0.363c-0.055-0.101-0.104-0.202-0.146-0.303c-0.048-0.119-0.086-0.238-0.114-0.356 C5.541,21.825,5.5,21.662,5.5,21.5v-8.207c0.12,0.109,0.257,0.216,0.387,0.324c0.072,0.06,0.139,0.12,0.215,0.18 c0.3,0.236,0.624,0.469,0.975,0.696c0.073,0.047,0.155,0.093,0.231,0.14c0.294,0.183,0.605,0.362,0.932,0.538 c0.121,0.065,0.242,0.129,0.367,0.193c0.365,0.186,0.748,0.366,1.151,0.542c0.066,0.029,0.126,0.059,0.193,0.087 c0.469,0.199,0.967,0.389,1.485,0.572c0.143,0.051,0.293,0.099,0.44,0.149c0.412,0.139,0.838,0.272,1.279,0.401 c0.159,0.046,0.315,0.094,0.478,0.139c0.585,0.162,1.189,0.316,1.823,0.458c0.087,0.02,0.181,0.037,0.269,0.056 c0.559,0.122,1.139,0.235,1.735,0.34c0.202,0.036,0.407,0.07,0.613,0.104c0.567,0.093,1.151,0.179,1.75,0.257 c0.154,0.02,0.301,0.042,0.457,0.062c0.744,0.09,1.514,0.167,2.305,0.233c0.195,0.016,0.398,0.028,0.596,0.042 c0.633,0.046,1.28,0.084,1.942,0.114c0.241,0.011,0.481,0.022,0.727,0.03C26.712,18.979,27.59,19,28.5,19s1.788-0.021,2.65-0.05 c0.245-0.008,0.485-0.02,0.727-0.03c0.662-0.03,1.309-0.068,1.942-0.114c0.198-0.015,0.4-0.026,0.596-0.042 c0.791-0.065,1.561-0.143,2.305-0.233c0.156-0.019,0.303-0.042,0.457-0.062c0.599-0.078,1.182-0.164,1.75-0.257 c0.206-0.034,0.411-0.068,0.613-0.104c0.596-0.105,1.176-0.218,1.735-0.34c0.088-0.019,0.182-0.036,0.269-0.056 c0.634-0.142,1.238-0.296,1.823-0.458c0.163-0.045,0.319-0.092,0.478-0.139c0.441-0.128,0.867-0.262,1.279-0.401 c0.147-0.05,0.297-0.098,0.44-0.149c0.518-0.184,1.017-0.374,1.485-0.572c0.067-0.028,0.127-0.059,0.193-0.087 c0.403-0.176,0.786-0.356,1.151-0.542c0.125-0.064,0.247-0.128,0.367-0.193c0.327-0.175,0.638-0.354,0.932-0.538 c0.076-0.047,0.158-0.093,0.231-0.14c0.351-0.227,0.675-0.459,0.975-0.696c0.075-0.06,0.142-0.12,0.215-0.18 C51.243,13.509,51.38,13.402,51.5,13.293z M28.5,2c13.554,0,23,3.952,23,7.5s-9.446,7.5-23,7.5s-23-3.952-23-7.5S14.946,2,28.5,2z");
        public static readonly Geometry serverConnected = Geometry.Parse("M48.179,38.429l-5.596,8.04l-3.949-3.241c-0.426-0.351-1.057-0.287-1.407,0.138c-0.351,0.427-0.289,1.058,0.139,1.407 l4.786,3.929c0.18,0.148,0.404,0.228,0.634,0.228c0.045,0,0.091-0.003,0.137-0.01c0.276-0.038,0.524-0.19,0.684-0.419l6.214-8.929 c0.315-0.453,0.204-1.076-0.25-1.392C49.117,37.86,48.495,37.975,48.179,38.429z M51,33.774V33.5V22v-0.5v-12V9c0-0.182-0.062-0.343-0.146-0.49C49.697,4.22,41.078,0,26,0S2.303,4.22,1.146,8.51 C1.062,8.657,1,8.818,1,9v0.5v12V22v11.5V34v12c0,0.162,0.042,0.315,0.117,0.451C2.297,51.346,12.864,55,26,55 c3.166,0,6.247-0.22,9.176-0.643C37.356,56.008,40.061,57,43,57c7.168,0,13-5.832,13-13C56,39.85,54.038,36.156,51,33.774z M47.749,31.911c-0.14-0.055-0.281-0.104-0.422-0.155c-0.311-0.11-0.627-0.208-0.948-0.295c-0.16-0.043-0.319-0.087-0.48-0.124 c-0.327-0.075-0.659-0.132-0.995-0.182c-0.148-0.022-0.294-0.051-0.443-0.068C43.98,31.034,43.494,31,43,31 c-0.415,0-0.824,0.024-1.23,0.063c-0.135,0.013-0.267,0.035-0.401,0.051c-0.269,0.034-0.537,0.072-0.801,0.123 c-0.153,0.029-0.303,0.063-0.453,0.098c-0.245,0.056-0.487,0.118-0.727,0.188c-0.146,0.042-0.292,0.085-0.436,0.133 c-0.252,0.083-0.5,0.176-0.745,0.273c-0.119,0.047-0.24,0.091-0.357,0.142c-0.331,0.143-0.655,0.299-0.971,0.468 c-0.025,0.014-0.052,0.025-0.078,0.039c-0.358,0.195-0.704,0.407-1.041,0.633c-0.037,0.025-0.072,0.053-0.109,0.079 c-0.29,0.199-0.571,0.41-0.844,0.632c-0.067,0.054-0.13,0.111-0.196,0.167c-0.239,0.203-0.471,0.413-0.695,0.632 c-0.068,0.067-0.135,0.134-0.202,0.203c-0.215,0.22-0.422,0.448-0.621,0.684c-0.061,0.072-0.123,0.142-0.182,0.215 c-0.202,0.249-0.392,0.505-0.576,0.769c-0.046,0.066-0.095,0.129-0.139,0.195c-0.217,0.325-0.424,0.659-0.612,1.006 c-0.015,0.027-0.027,0.055-0.042,0.082c-0.167,0.313-0.323,0.635-0.465,0.964c-0.083,0.191-0.153,0.39-0.228,0.586 c-0.06,0.16-0.123,0.319-0.177,0.482c-0.078,0.233-0.144,0.472-0.209,0.711c-0.021,0.077-0.048,0.15-0.067,0.228 c-0.398,0.027-0.797,0.051-1.197,0.07c-0.267,0.013-0.532,0.03-0.799,0.04C27.6,40.982,26.799,41,26,41 c-0.827,0-1.637-0.016-2.432-0.044c-0.482-0.018-0.947-0.049-1.417-0.076c-0.297-0.017-0.603-0.028-0.895-0.049 c-0.624-0.045-1.23-0.103-1.829-0.165c-0.12-0.013-0.246-0.021-0.365-0.034c-0.686-0.075-1.354-0.161-2.005-0.256 c-0.024-0.003-0.049-0.006-0.072-0.009c-3.379-0.499-6.279-1.26-8.548-2.165c-0.017-0.007-0.035-0.013-0.051-0.02 c-0.414-0.167-0.803-0.338-1.174-0.514c-0.047-0.022-0.097-0.044-0.144-0.067c-0.333-0.16-0.64-0.325-0.935-0.491 c-0.073-0.042-0.15-0.083-0.221-0.125c-0.256-0.15-0.49-0.304-0.714-0.458c-0.089-0.062-0.18-0.123-0.263-0.185 c-0.188-0.139-0.358-0.28-0.52-0.421c-0.092-0.08-0.183-0.16-0.266-0.241C4.016,35.551,3.9,35.422,3.79,35.293 c-0.08-0.094-0.156-0.188-0.224-0.283c-0.087-0.121-0.161-0.242-0.227-0.363c-0.055-0.101-0.104-0.202-0.146-0.303 c-0.048-0.119-0.086-0.238-0.114-0.356C3.041,33.825,3,33.662,3,33.5v-8.207c0.018,0.016,0.039,0.032,0.057,0.048 c0.232,0.205,0.47,0.409,0.738,0.605C7.567,28.791,15.095,31,26,31c10.88,0,18.396-2.199,22.177-5.034 c0.29-0.212,0.55-0.431,0.799-0.653c0.008-0.007,0.017-0.014,0.024-0.021v7.181c-0.053-0.028-0.11-0.046-0.164-0.074 C48.482,32.221,48.12,32.057,47.749,31.911z M3.601,13.797c0.3,0.236,0.624,0.469,0.975,0.696c0.073,0.047,0.155,0.093,0.231,0.14 c0.294,0.183,0.605,0.362,0.932,0.538c0.121,0.065,0.242,0.129,0.367,0.193c0.365,0.186,0.748,0.366,1.151,0.542 c0.066,0.029,0.126,0.059,0.193,0.087c0.469,0.199,0.967,0.389,1.485,0.572c0.143,0.051,0.293,0.099,0.44,0.149 c0.412,0.139,0.838,0.272,1.279,0.401c0.159,0.046,0.315,0.094,0.478,0.139c0.585,0.162,1.189,0.316,1.823,0.458 c0.087,0.02,0.181,0.037,0.269,0.056c0.559,0.122,1.139,0.235,1.735,0.34c0.202,0.036,0.407,0.07,0.613,0.104 c0.567,0.093,1.151,0.179,1.75,0.257c0.154,0.02,0.301,0.042,0.457,0.062c0.744,0.09,1.514,0.167,2.305,0.233 c0.195,0.016,0.398,0.028,0.596,0.042c0.633,0.046,1.28,0.084,1.942,0.114c0.241,0.011,0.481,0.022,0.727,0.03 C24.212,18.979,25.09,19,26,19s1.788-0.021,2.65-0.05c0.245-0.008,0.485-0.02,0.727-0.03c0.662-0.03,1.309-0.068,1.942-0.114 c0.198-0.015,0.4-0.026,0.596-0.042c0.791-0.065,1.561-0.143,2.305-0.233c0.156-0.019,0.303-0.042,0.457-0.062 c0.599-0.078,1.182-0.164,1.75-0.257c0.206-0.034,0.411-0.068,0.613-0.104c0.596-0.105,1.176-0.218,1.735-0.34 c0.088-0.019,0.182-0.036,0.269-0.056c0.634-0.142,1.238-0.296,1.823-0.458c0.163-0.045,0.319-0.092,0.478-0.139 c0.441-0.128,0.867-0.262,1.279-0.401c0.147-0.05,0.297-0.098,0.44-0.149c0.518-0.184,1.017-0.374,1.485-0.572 c0.067-0.028,0.127-0.059,0.193-0.087c0.403-0.176,0.786-0.356,1.151-0.542c0.125-0.064,0.247-0.128,0.367-0.193 c0.327-0.175,0.638-0.354,0.932-0.538c0.076-0.047,0.158-0.093,0.231-0.14c0.351-0.227,0.675-0.459,0.975-0.696 c0.075-0.06,0.142-0.12,0.215-0.18c0.13-0.108,0.267-0.215,0.387-0.324V21.5c0,0.163-0.041,0.327-0.08,0.491 c-0.028,0.117-0.065,0.233-0.112,0.351c-0.042,0.103-0.092,0.206-0.148,0.309c-0.066,0.119-0.138,0.238-0.223,0.357 c-0.069,0.096-0.147,0.192-0.228,0.289c-0.108,0.127-0.223,0.254-0.353,0.38c-0.085,0.083-0.178,0.165-0.272,0.247 c-0.16,0.139-0.327,0.278-0.513,0.415c-0.086,0.064-0.18,0.127-0.271,0.19c-0.222,0.153-0.453,0.305-0.706,0.453 c-0.074,0.044-0.153,0.087-0.23,0.13c-0.292,0.165-0.597,0.328-0.926,0.487c-0.049,0.023-0.103,0.047-0.153,0.071 c-0.369,0.174-0.754,0.345-1.166,0.51c-0.019,0.007-0.039,0.015-0.058,0.022c-2.269,0.904-5.166,1.665-8.543,2.164 c-0.024,0.003-0.05,0.006-0.074,0.01c-0.651,0.095-1.318,0.181-2.003,0.256c-0.12,0.013-0.246,0.022-0.367,0.034 c-0.599,0.062-1.204,0.12-1.827,0.165c-0.293,0.021-0.599,0.032-0.897,0.049c-0.469,0.027-0.934,0.059-1.416,0.076 C27.637,28.984,26.827,29,26,29s-1.637-0.016-2.432-0.044c-0.482-0.018-0.947-0.049-1.417-0.076 c-0.297-0.017-0.603-0.028-0.895-0.049c-0.624-0.045-1.23-0.103-1.829-0.165c-0.12-0.013-0.246-0.021-0.365-0.034 c-0.686-0.075-1.354-0.161-2.005-0.256c-0.024-0.003-0.049-0.006-0.072-0.009c-3.379-0.499-6.279-1.26-8.548-2.165 c-0.017-0.007-0.035-0.013-0.051-0.02c-0.414-0.167-0.803-0.338-1.174-0.514c-0.047-0.022-0.097-0.044-0.144-0.067 c-0.333-0.16-0.64-0.325-0.935-0.491c-0.073-0.042-0.15-0.083-0.221-0.125c-0.256-0.15-0.49-0.304-0.714-0.458 c-0.089-0.062-0.18-0.123-0.263-0.185c-0.188-0.139-0.358-0.28-0.52-0.421c-0.092-0.08-0.183-0.16-0.266-0.241 C4.016,23.551,3.9,23.422,3.79,23.293c-0.08-0.094-0.156-0.188-0.224-0.283c-0.087-0.121-0.161-0.242-0.227-0.363 c-0.055-0.101-0.104-0.202-0.146-0.303c-0.048-0.119-0.086-0.238-0.114-0.356C3.041,21.825,3,21.662,3,21.5v-8.207 c0.12,0.109,0.257,0.216,0.387,0.324C3.459,13.677,3.526,13.737,3.601,13.797z M26,2c13.554,0,23,3.952,23,7.5S39.554,17,26,17 S3,13.048,3,9.5S12.446,2,26,2z M26,53c-13.037,0-22.401-3.703-22.968-7.162C3.024,45.793,3.014,45.749,3,45.707v-8.414 c0.018,0.016,0.039,0.032,0.057,0.048c0.232,0.205,0.47,0.409,0.738,0.605C7.567,40.791,15.095,43,26,43 c0.797,0,1.596-0.019,2.394-0.047c0.239-0.008,0.476-0.021,0.715-0.032c0.314-0.014,0.63-0.023,0.943-0.042 C30.018,43.259,30,43.633,30,44c0,0.425,0.024,0.847,0.064,1.265c0.013,0.135,0.038,0.267,0.055,0.4 c0.036,0.282,0.074,0.563,0.129,0.84c0.029,0.147,0.067,0.29,0.101,0.436c0.061,0.261,0.124,0.521,0.2,0.778 c0.041,0.138,0.089,0.273,0.135,0.41c0.087,0.259,0.179,0.516,0.282,0.77c0.05,0.123,0.103,0.243,0.157,0.363 c0.115,0.26,0.238,0.516,0.37,0.768c0.057,0.107,0.115,0.214,0.174,0.32c0.143,0.254,0.294,0.503,0.454,0.747 c0.064,0.098,0.128,0.195,0.194,0.291c0.166,0.239,0.341,0.471,0.523,0.699c0.075,0.095,0.15,0.19,0.228,0.282 c0.063,0.075,0.12,0.155,0.185,0.229C30.913,52.864,28.483,53,26,53z M43,55c-2.64,0-5.065-0.937-6.963-2.492 c-0.293-0.241-0.572-0.495-0.836-0.76c-0.108-0.109-0.206-0.227-0.309-0.34c-0.151-0.165-0.303-0.33-0.443-0.503 c-0.119-0.147-0.228-0.301-0.34-0.454c-0.111-0.152-0.221-0.304-0.323-0.461c-0.107-0.164-0.207-0.332-0.305-0.501 c-0.093-0.161-0.182-0.323-0.267-0.488c-0.087-0.17-0.171-0.342-0.249-0.517c-0.081-0.18-0.154-0.363-0.224-0.547 c-0.065-0.167-0.129-0.335-0.186-0.506c-0.068-0.208-0.125-0.42-0.181-0.632c-0.041-0.156-0.087-0.311-0.121-0.47 c-0.054-0.25-0.092-0.504-0.128-0.759c-0.019-0.129-0.045-0.256-0.059-0.388C32.024,44.791,32,44.397,32,44 c0-0.343,0.021-0.681,0.052-1.017c0.032-0.328,0.079-0.661,0.143-1.004c0.05-0.271,0.116-0.535,0.185-0.798 c0.019-0.073,0.036-0.146,0.056-0.219c0.063-0.22,0.137-0.435,0.212-0.648c0.042-0.117,0.083-0.234,0.128-0.35 c0.07-0.177,0.146-0.352,0.225-0.524c0.068-0.149,0.139-0.298,0.214-0.444c0.072-0.14,0.146-0.278,0.223-0.415 c0.1-0.176,0.206-0.348,0.315-0.518c0.067-0.105,0.133-0.21,0.204-0.313c0.14-0.202,0.289-0.398,0.442-0.59 c0.053-0.066,0.102-0.134,0.156-0.199c0.208-0.25,0.426-0.491,0.656-0.722c0.006-0.006,0.011-0.012,0.017-0.018 c0.486-0.485,1.018-0.924,1.587-1.313c0.065-0.044,0.134-0.084,0.2-0.127c0.212-0.138,0.428-0.271,0.65-0.395 c0.102-0.057,0.206-0.108,0.309-0.161c0.193-0.1,0.389-0.196,0.588-0.284c0.122-0.054,0.245-0.104,0.369-0.154 c0.19-0.076,0.383-0.146,0.578-0.212c0.133-0.044,0.266-0.088,0.401-0.127c0.197-0.058,0.398-0.107,0.599-0.154 c0.134-0.031,0.268-0.064,0.404-0.091c0.222-0.043,0.448-0.074,0.675-0.104c0.119-0.015,0.236-0.036,0.355-0.047 C42.292,33.02,42.643,33,43,33c0.341,0,0.677,0.021,1.01,0.051c0.104,0.009,0.207,0.023,0.311,0.036 c0.234,0.028,0.465,0.064,0.694,0.106c0.111,0.021,0.222,0.041,0.333,0.065c0.244,0.053,0.484,0.117,0.721,0.186 c0.08,0.023,0.161,0.042,0.24,0.066c0.293,0.093,0.579,0.2,0.861,0.316c0.135,0.056,0.266,0.119,0.399,0.18 c0.154,0.071,0.306,0.143,0.456,0.22c0.149,0.077,0.296,0.158,0.442,0.242c0.125,0.072,0.246,0.147,0.368,0.224 c0.151,0.095,0.302,0.189,0.449,0.292C52.13,36.974,54,40.271,54,44C54,50.065,49.065,55,43,55z");
        public static readonly Geometry serverConnecting = Geometry.Parse("M55.199,47.02c-0.549-0.108-1.069,0.241-1.18,0.781C52.903,53.303,48.574,57,43.249,57c-5.028,0-9.446-3.3-10.948-8H37v-2 h-8v8h2v-3.849C33.169,55.833,37.915,59,43.249,59c6.304,0,11.42-4.341,12.731-10.801C56.09,47.657,55.74,47.13,55.199,47.02z M55,35v4.309C52.75,34.854,48.296,32,43.249,32c-6.109,0-11.541,3.997-13.209,9.721c-0.154,0.53,0.15,1.085,0.681,1.239 c0.531,0.152,1.086-0.151,1.239-0.681C33.358,37.482,38.105,34,43.249,34c4.565,0,8.562,2.766,10.33,7H49v2h8v-8H55z M27,41.185c-0.827,0-1.637-0.016-2.432-0.044c-0.483-0.018-0.95-0.049-1.422-0.076c-0.296-0.017-0.6-0.028-0.891-0.049 c-0.626-0.045-1.234-0.103-1.835-0.165c-0.118-0.012-0.242-0.021-0.359-0.034c-0.688-0.075-1.358-0.161-2.012-0.257 c-0.021-0.003-0.044-0.006-0.066-0.009c-3.382-0.5-6.284-1.261-8.554-2.167c-0.014-0.006-0.03-0.011-0.044-0.017 c-0.417-0.167-0.807-0.34-1.18-0.516c-0.045-0.021-0.093-0.042-0.138-0.064c-0.334-0.161-0.644-0.327-0.94-0.494 c-0.072-0.041-0.146-0.081-0.216-0.122c-0.258-0.151-0.493-0.306-0.718-0.461c-0.087-0.061-0.177-0.121-0.259-0.182 c-0.19-0.141-0.361-0.282-0.524-0.425c-0.09-0.079-0.18-0.157-0.261-0.237c-0.134-0.129-0.252-0.26-0.363-0.391 c-0.078-0.092-0.153-0.185-0.219-0.277c-0.088-0.123-0.163-0.246-0.231-0.369c-0.054-0.099-0.102-0.198-0.143-0.297 c-0.049-0.121-0.088-0.242-0.116-0.362C4.041,34.008,4,33.845,4,33.685v-8.207c0.028,0.026,0.063,0.051,0.092,0.077 c0.218,0.191,0.44,0.382,0.69,0.566c3.767,2.85,11.301,5.063,22.219,5.063c10.872,0,18.386-2.196,22.169-5.028 c0.302-0.22,0.574-0.447,0.83-0.678l0.001,0v3.707c0,0.553,0.447,1,1,1s1-0.447,1-1v-7v-0.5v-12v-0.5 c0-0.162-0.047-0.309-0.115-0.444C50.695,3.769,40.195,0,27,0C13.805,0,3.304,3.769,2.115,8.74C2.047,8.875,2,9.022,2,9.185v0.5v12 v0.5v11.5v0.5v12c0,0.161,0.042,0.313,0.115,0.448c1.139,4.833,10.691,7.68,19.81,8.364C21.95,54.999,21.976,55,22.001,55 c0.519,0,0.957-0.399,0.996-0.925c0.041-0.551-0.371-1.031-0.922-1.072c-11.114-0.834-17.591-4.219-18.043-6.98 C4.024,45.978,4.014,45.935,4,45.892v-8.414c0.028,0.026,0.063,0.051,0.092,0.077c0.218,0.191,0.44,0.382,0.69,0.566 c3.767,2.85,11.301,5.063,22.219,5.063c0.553,0,1-0.447,1-1S27.553,41.185,27,41.185z M4.601,13.981 c0.3,0.236,0.624,0.469,0.975,0.696c0.073,0.047,0.155,0.093,0.231,0.14C6.102,15,6.412,15.18,6.74,15.355 c0.121,0.065,0.242,0.129,0.367,0.193c0.365,0.186,0.748,0.366,1.151,0.542c0.066,0.029,0.126,0.059,0.193,0.087 c0.469,0.199,0.967,0.389,1.485,0.572c0.143,0.051,0.293,0.099,0.44,0.149c0.412,0.139,0.838,0.272,1.279,0.401 c0.159,0.046,0.315,0.094,0.478,0.139c0.585,0.162,1.189,0.316,1.823,0.458c0.087,0.02,0.181,0.037,0.269,0.056 c0.559,0.122,1.139,0.235,1.735,0.34c0.202,0.036,0.407,0.07,0.613,0.104c0.567,0.093,1.151,0.179,1.75,0.257 c0.154,0.02,0.301,0.042,0.457,0.062c0.744,0.09,1.514,0.167,2.305,0.233c0.195,0.016,0.398,0.028,0.596,0.042 c0.633,0.046,1.28,0.084,1.942,0.114c0.241,0.011,0.481,0.022,0.727,0.03c0.863,0.03,1.741,0.05,2.65,0.05s1.788-0.021,2.65-0.05 c0.245-0.008,0.485-0.02,0.727-0.03c0.662-0.03,1.309-0.068,1.942-0.114c0.198-0.015,0.4-0.026,0.596-0.042 c0.791-0.065,1.561-0.143,2.305-0.233c0.156-0.019,0.303-0.042,0.457-0.062c0.599-0.078,1.182-0.164,1.75-0.257 c0.206-0.034,0.411-0.068,0.613-0.104c0.596-0.105,1.176-0.218,1.735-0.34c0.088-0.019,0.182-0.036,0.269-0.056 c0.634-0.142,1.238-0.296,1.823-0.458c0.163-0.045,0.319-0.092,0.478-0.139c0.441-0.128,0.867-0.262,1.279-0.401 c0.147-0.05,0.297-0.098,0.44-0.149c0.518-0.184,1.017-0.374,1.485-0.572c0.067-0.028,0.127-0.059,0.193-0.087 c0.403-0.176,0.786-0.356,1.151-0.542c0.125-0.064,0.247-0.128,0.367-0.193c0.327-0.175,0.638-0.354,0.932-0.538 c0.076-0.047,0.158-0.093,0.231-0.14c0.351-0.227,0.675-0.459,0.975-0.696c0.075-0.06,0.142-0.12,0.215-0.18 c0.13-0.108,0.267-0.215,0.387-0.324v8.207c0,0.161-0.041,0.323-0.079,0.485c-0.028,0.121-0.067,0.241-0.116,0.362 c-0.04,0.099-0.089,0.198-0.143,0.297c-0.067,0.123-0.142,0.246-0.231,0.369c-0.066,0.092-0.141,0.185-0.219,0.277 c-0.111,0.13-0.229,0.261-0.363,0.391c-0.082,0.08-0.171,0.158-0.261,0.237c-0.163,0.143-0.334,0.284-0.524,0.425 c-0.082,0.061-0.172,0.121-0.259,0.182c-0.225,0.155-0.46,0.31-0.718,0.461c-0.069,0.041-0.144,0.082-0.216,0.122 c-0.296,0.167-0.606,0.333-0.94,0.494c-0.045,0.022-0.093,0.043-0.138,0.064c-0.373,0.176-0.763,0.349-1.18,0.516 c-0.014,0.006-0.03,0.011-0.044,0.017c-2.27,0.906-5.172,1.667-8.554,2.167c-0.021,0.003-0.044,0.005-0.066,0.009 c-0.653,0.096-1.324,0.182-2.012,0.257c-0.117,0.013-0.241,0.021-0.359,0.034c-0.602,0.062-1.21,0.12-1.835,0.165 c-0.291,0.021-0.595,0.032-0.891,0.049c-0.471,0.027-0.938,0.059-1.422,0.076c-0.795,0.028-1.606,0.044-2.432,0.044 s-1.637-0.016-2.432-0.044c-0.483-0.018-0.95-0.049-1.422-0.076c-0.296-0.017-0.6-0.028-0.891-0.049 c-0.626-0.045-1.234-0.103-1.835-0.165c-0.118-0.012-0.242-0.021-0.359-0.034c-0.688-0.075-1.358-0.161-2.012-0.257 c-0.021-0.003-0.044-0.006-0.066-0.009c-3.382-0.5-6.284-1.261-8.554-2.167c-0.014-0.006-0.03-0.011-0.044-0.017 c-0.417-0.167-0.807-0.34-1.18-0.516c-0.045-0.021-0.093-0.042-0.138-0.064c-0.334-0.161-0.644-0.327-0.94-0.494 c-0.072-0.041-0.146-0.081-0.216-0.122c-0.258-0.151-0.493-0.306-0.718-0.461c-0.087-0.061-0.177-0.121-0.259-0.182 c-0.19-0.141-0.361-0.282-0.524-0.425c-0.09-0.079-0.18-0.157-0.261-0.237c-0.134-0.129-0.252-0.26-0.363-0.391 c-0.078-0.092-0.153-0.185-0.219-0.277c-0.088-0.123-0.163-0.246-0.231-0.369c-0.054-0.099-0.102-0.198-0.143-0.297 c-0.049-0.121-0.088-0.242-0.116-0.362C4.041,22.008,4,21.845,4,21.685v-8.207c0.12,0.109,0.257,0.216,0.387,0.324 C4.459,13.861,4.526,13.922,4.601,13.981z M27,2c13.555,0,23,4.05,23,7.685c0,3.548-9.445,7.5-23,7.5s-23-3.952-23-7.5 C4,6.05,13.445,2,27,2z");
        #endregion

        public Geometry Logo
        {
            set
            {
                logo = value;
                NotifyPropertyChanged("Logo");
            }
            get
            {
                return logo;
            }
        }


        public MainWindowViewModel()
        {
            Logo = serverDisconnected;  //default robot icon
        }
    }
}
