import unittest
from Main import *

class Test_answers(unittest.TestCase):

    def test_answer1(self):
        expected = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
        actual = answer1([3, 4, 1, 5, 9, 2, 6, 0, 7, 8])
        
        self.assertEqual(expected, actual)

    def test_answer2(self):
        expected = [0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0]
        actual = answer2([0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 2.0, 3.0, 4.0, 5.0], [0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0])
        
        self.assertEqual(expected, actual)

    def test_answer3(self):
        expected = 5.0
        actual = answer3([0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 2.0, 3.0, 4.0, 5.0], [0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0])
        
        self.assertEqual(expected, actual)

if __name__ == '__main__':
    unittest.main()
